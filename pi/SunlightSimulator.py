
import pika
import subprocess
import serial
import os
import signal
import time
import sys
import Queue 
import numpy as np
import scipy.optimize as optimize
import scipy.interpolate as interpolate
import atexit
from threading import Timer,Thread,Event

def map_func(n):
	p = f(n)
	return p

def thread_get_queue():
	while True:
		items = queue.get()
		func = items[0]
		func(*items[1:])
	
def send_to_pc(q, object, message):
	def func(a, b, c):
		print("inizio invio")
		props = pika.BasicProperties(headers={'object':b})
		channel.basic_publish(routing_key="",exchange='PItoPC', properties=props, body=c)
		print(c)
		print("fine invio")
	queue.put((func, q, object, message))
	


def send_to_arduino(channel, power):
    s = channel + str(power) + 'f'
    print(s)
    ser.write(s)

def start_simulation(heatingEnabled):
    global stopFlag
    global powersIndex
    global timeStep
    global powers
    global startIndex
    global endIndex
    global numChan
    global mainPowers
    mainPowers = powers[:]
    heatingArray = [currPower.copy()]
    if(heatingEnabled):
            heatingArray = []
            heatingArray = pre_heating()
##    print(heatingArray)
    startArray = reach_power(heatingArray[len(heatingArray)-1], powers[0])
    endArray = reach_power(powers[len(powers)-1], np.repeat(0,numChan))
    #print(startArray)
    #print(endArray)
    startIndex = len(startArray) + len(heatingArray)
    endIndex = startIndex + len(powers)
    heatingArray.extend(startArray)
    heatingArray.extend(powers)
    heatingArray.extend(endArray)
    timeStep = 5
    powers = heatingArray

    send_to_pc('PItoPC', 0, 'h')
    powersIndex = -1
    stopFlag = Event()
    thread = MyThread(stopFlag)
    thread.start()

def pre_heating():
        heating_powers = []
        heating_powers.extend(reach_power(np.repeat(0,numChan), np.repeat(30,numChan)))
        for i in range(24): #!!!!!!!!!!!!!!!!!!!
                heating_powers.append(np.repeat(30,numChan))
        return heating_powers

def reach_power(startPower, endPower):
    reachingPowers = []
    sign = np.repeat(1,numChan)
    for i in range(numChan):
            if(startPower[i]>endPower[i]):
                sign[i] = -1
    p = startPower.copy()
    reached = False
    while (not reached):
        reachingPowers.append(p.copy())
        reached = True
        for i in range(numChan):
                if(sign[i]*p[i] < sign[i]*endPower[i]):
                        reached = False
                        p[i] += sign[i]*20
                        if(p[i]*sign[i] > endPower[i]*sign[i]):
                                p[i] = endPower[i].copy()
    return reachingPowers

class MyThread(Thread):
    def __init__(self, event):
        Thread.__init__(self)
        self.stopped = event

    def run(self):
        global currPower
        global powersIndex
        global startIndex
        global endIndex
        global timeStep
        global powers
        while not self.stopped.wait(timeStep):
            powersIndex = powersIndex + 1
            if(powersIndex >= len(powers)):
                stopFlag.set()
                send_to_pc('PItoPC', 0, 'r')
                powersIndex = -1
                powers = []
                endIndex = startIndex = -1
            else:
				if(powersIndex == startIndex):
					message = ''
					for i in range(len(mainPowers)):
						for j in range(len(mainPowers[i])):
							message += str(mainPowers[i][j]) + ';'
					message += "/"
					for i in range(len(powersToReach)):
						message += str(powersToReach[i]) + ";"
					timeStep = 60
					send_to_pc('PItoPC', 0, 's' + message)
				elif(powersIndex == endIndex):
					send_to_pc('PItoPC', 0, 'c')
					timeStep = 5
				for i in range(6):
					if(powers[powersIndex][int(i*numChan/6)] != currPower[int(i*numChan/6)]):
						send_to_arduino(str(i+1), powers[powersIndex][int(i*numChan/6)])
				currPower = powers[powersIndex].copy()
def update_standard_powers(s):
        global standardPowers
        global standardPowersMapped
        p = s.split(';')
        for i in range(6):
                standardPowers[i] = int(p[i])
        standardPowersMapped = f2(standardPowers*100.0/255.0)*255.0/100.0
def update_max_powers(s):
        global maxPowersLandscape
        global maxPowersPortrait
        maxPowers = s.split(';')
        maxPowersIndex = 0
        for i in range(numChan):
                for j in range(6):
                        maxPowersLandscape[j][i] = int(maxPowers[maxPowersIndex])
                        maxPowersIndex += 1
        for i in range(numChan):
                for j in range(6):
                        maxPowersPortrait[j][i] = int(maxPowers[maxPowersIndex])
                        maxPowersIndex += 1
def on_closing():
	try:
		send_to_pc('PItoPC', 3, 'e')
	except:
		pass
	stopFlag
	stopFlag.set()
	os.execv(sys.executable, ['python'] + sys.argv)
	
def calc_power(powerToReach):
	global display
	global numChan
	global standardPowersMapped
	r = np.repeat(0.0,6)

	if(mode == 'st'):
		for i in range(6):
			r[i] = standardPowersMapped[i] * (powerToReach/600.0)
	else:
		if(display == "l"):
				A = maxPowersLandscape/127.0
		else:
				A = maxPowersPortrait/127.0
		b = np.repeat(powerToReach, 6)
		def f(x):
				y = np.dot(A, x) - b
				return np.dot(y, y)

		res = optimize.minimize(fun=f, x0=np.repeat(127,numChan),
								bounds=((0, 200),) * numChan)
		r = res['x']
	r = np.around(map_func(r*100.0/255.0)*255.0/100.0)
	for i in range(6):
		if(r[i] > 200):
			r[i] = 200
	return r

def callback(ch, method, properties, body):
    case = properties.headers["Object"]
    global powers
    global timeStep
    global thread
    global stopFlag
    global powersIndex
    global startIndex
    global endIndex
    global currPower
    global display
    global newConfigurationStarted
    global directPowersControl
    global mode
    global mainPowers
    global powersToReach
    message = str(body)
    if(case  == 0):
        p = ""
        powersToReach = []
        powers = []
        mainPowers = []
        for c in message:
            if(c == ';'):
                powersToReach.append(int(p))
                p = ""
            else:
                p = p+c
        print(powersToReach)
        for i in range(len(powersToReach)):
            powers.append(calc_power(powersToReach[i]).astype(int))
            print(powersToReach[i])
            print(powers[i])
        start_simulation(True)
    elif(case == 1):
        if(message == 'r'):
            stopFlag.set()
            powers = reach_power(currPower, np.repeat(0, numChan))
            endIndex = 0
            newConfigurationStarted = False
            directPowersControl = False
            startIndex = -1
            timeStep = 5
            powersIndex = -1
            stopFlag = Event()
            thread = MyThread(stopFlag)
            thread.start()
        elif(message == 's'):
            if(len(powers) == 0):
                send_to_pc('PItoPC', 1, 'no')
            else:
                send_to_pc('PItoPC', 1, 'yes')
            fileMaxPowers = open("maxPowers.txt","r")
            send_to_pc('PItoPC', 2, fileMaxPowers.read())
            fileMaxPowers.close()
            fileStandardPowers = open("standardPowers.txt", "r")
            send_to_pc('PItoPC', 4, fileStandardPowers.read())
            fileStandardPowers.close()
            send_to_pc('PItoPC', 0, display)
            send_to_pc('PItoPC', 0, mode)
        elif(message == "l"):
                display = "l"
        elif(message == "p"):
                display = "p"
        elif(message == "st" or message == "ad"):
			mode = message
            
    elif(case == 2):
        update_max_powers(message)
        fileMaxPowers = open("maxPowers.txt", "w")
        fileMaxPowers.write(message)
        fileMaxPowers.close()

    elif(case == 3):
            p = np.repeat(0, numChan)
            powers = []
            mainPowers = []
            p[int(message)] = 127
            for i in range(120):
                    powers.append(p)
            #print(powers)
            stopFlag.set()
            start_simulation(not newConfigurationStarted)
            newConfigurationStarted = True

    elif(case == 4):
			powerToReach = np.repeat(0,6)
			p = ''
			i = 0
			for c in message:
				if(c == ';'):
					powerToReach[i] = int(p)
					i+=1
					p = ""
				else:
					p = p+c
			if(not directPowersControl):
					for i in range(300):
							powers.append(powerToReach.copy())
					start_simulation(True)
					directPowersControl = True
			else:
					stopFlag.set()
					powers = []
					mainPowers = []
					directPower = powerToReach.copy()
					for i in range(6):
						if(directPower[int(i*numChan/6)] != currPower[int(i*numChan/6)]):
							send_to_arduino(str(i+1), directPower[int(i*numChan/6)])
					currPower = directPower.copy()
    elif(case == 5):
        update_standard_powers(message)
        fileStandardPowers = open("standardPowers.txt", "w")
        fileStandardPowers.write(message)
        fileStandardPowers.close()
    elif(case == 6):
		powerToReach = np.repeat(0,6)
		p = ''
		i = 0
		for c in message:
			if(c == ';'):
				powerToReach[i] = int(p)
				i+=1
				p = ""
			else:
				p = p+c
		for i in range(6):
			if(powerToReach[int(i*numChan/6)] != currPower[int(i*numChan/6)]):
				send_to_arduino(str(i+1), powerToReach[int(i*numChan/6)])
		currPower = powerToReach.copy()
		for i in range(powersIndex, endIndex):
			powers[i] = powerToReach.copy()
		powers = powers[:endIndex]
		powers.extend(reach_power(powerToReach, np.repeat(0,numChan)))
		print(len(powers))

thread_queue = Thread(target = thread_get_queue)
queue = Queue.Queue()
mode = 'st'
numChan = 6
directPowersControl = False
stopFlag = Event()
maxPowersLandscape = np.zeros((6,numChan))
maxPowersPortrait = np.zeros((6,numChan))
display = "l"
powers = []
currPower = np.repeat(0,numChan)
powersIndex = 0
startIndex = 0
endIndex = 0
timeStep = 60
mainPowers = []
standardPowersMapped = np.repeat(200,6)
standardPowers = np.repeat(200,6)
f = interpolate.interp1d(x=[0.0, 0.196, 0.786, 2.947, 6.189, 9.823, 16.699, 49.312, 78.585, 100.000], 
							  y=[0.0, 3.922, 7.843, 11.765, 15.686, 19.608, 24.706, 49.804, 74.902, 100.000])
f2 = interpolate.interp1d(y=[0.0, 0.196, 0.786, 2.947, 6.189, 9.823, 16.699, 49.312, 78.585, 100.000], 
							  x=[0.0, 3.922, 7.843, 11.765, 15.686, 19.608, 24.706, 49.804, 74.902, 100.000])
atexit.register(on_closing)
try:
	newConfigurationStarted = False
	directPowersControl = False
	fileMaxPowers = open("maxPowers.txt", "r")
	update_max_powers(fileMaxPowers.read())
	fileMaxPowers.close()
	fileStandardPowers = open("standardPowers.txt", "r")
	update_standard_powers(fileStandardPowers.read())
	fileStandardPowers.close()
	oldProc = subprocess.Popen(['ps', '-A'], stdout=subprocess.PIPE)
	out, err = oldProc.communicate()
	for line in out.splitlines():
			if 'python' in line:
					pid = int(line.split(None, 1)[0])
					if(os.getpid() != pid):
							os.kill(pid, signal.SIGKILL)
	connected = False
	while(not connected):
			try:
				connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost', credentials=pika.PlainCredentials('default', 'default')))
				channel = connection.channel()
				connected = True
			except:
				pass

	channel.exchange_declare(exchange='PItoPC',
						 exchange_type='direct', auto_delete=False)

	channel.queue_declare(queue="PItoPC", auto_delete=False)


	channel.queue_bind(exchange='PItoPC',
				   queue="PItoPC")

	channel.exchange_declare(exchange='PCtoPI',
						 exchange_type='direct', auto_delete=False)

	channel.queue_declare(queue="PCtoPI", auto_delete=False)

	channel.queue_bind(exchange='PCtoPI',
				   queue="PCtoPI")
	channel.queue_purge("PCtoPI")

	ser = serial.Serial('/dev/ttyACM0', 9600)

	thread_queue.start()
	send_to_pc('PItoPC', 1, 'no')
	fileMaxPowers = open("maxPowers.txt","r")
	send_to_pc('PItoPC', 2, fileMaxPowers.read())
	fileMaxPowers.close()
	fileStandardPowers = open("standardPowers.txt", "r")
	send_to_pc('PItoPC', 4, fileStandardPowers.read())
	fileStandardPowers.close()
	send_to_pc('PItoPC', 0, display)
	send_to_pc('PItoPC', 0, mode)
	channel.basic_consume(callback,
					  queue="PCtoPI",
					  no_ack=True)
	channel.start_consuming()



except:
	try:
		send_to_pc('PItoPC', 3, 'e')
	except:
		pass
	stopFlag
	stopFlag.set()
	os.execv(sys.executable, ['python'] + sys.argv)
