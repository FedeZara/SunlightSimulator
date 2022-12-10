# Sunlight Simulator

The main purpose of this project is to provide an easy and intuitive way to simulate the solar light throughout a day.

## Description 

### Simulation

The user can interact with the simulator using a Windows program that offers two different types of simulation:

- The first one is simple: it consists of a constant emission of light at a custom power for a custom time.
- The second one lets the user import data in the .csv format from http://re.jrc.ec.europa.eu/pvg_tools/en/tools.html. The user can then choose from a range of settings, such as simulation time, to further customize the simulation.

After setting up the simulation, the user can start it and see its evolution over time in a graph inside the application.

### Calibration

In order to perform a proper simulation, the user must calibrate the program.

There are two ways to do it:

- The first one is manual calibration: the user is provided with a power value and must adjust the sliders in the program to match it on the surface where the lights are pointed.

- The second one is automatic calibration: the user is guided through some steps where they have to perform some calibration. The software then automatically configures itself by doing linear interpolation.

## Prerequisites

This project assumes that the trimmer which controls the lights uses a DMX interface as input for the commands. The trimmer is also expected to have 6 channels.
In order to make Arduino communicates with this trimmer, a DMX signal generator is required. 
This particular project uses the [DMX Master Shield](http://www.eu.diigiit.com/arduino-dmx-master-shield) from TinderKit and the [DmxSimple](https://github.com/PaulStoffregen/DmxSimple) library.

## Usage

### Setup the Arduino

To start, place the [TinderKit DMX Master Shield](http://www.eu.diigiit.com/arduino-dmx-master-shield) on top of the Arduino. Then, compile the .ino sketch and upload it to the Arduino.

### Setup the Raspberry Pi

- Connect the Raspberry Pi to the Arduino using an USB cable.
- The Raspberry and the Windows application communicate using the message broker RabbitMQ. Install a RabbitMQ server in the Raspberry following [this](https://www.rabbitmq.com/install-debian.html) guide. After installing the server, [create a new user](https://www.rabbitmq.com/rabbitmqctl.8.html#User_Management) and set it as Admin. Change line 374 of SunlightSimulator.py and insert your credentials:

```python
connection = pika.BlockingConnection(pika.ConnectionParameters(host='localhost', credentials=pika.PlainCredentials('yourusername', 'yourpassword')))
```
- Run the python program and check for any errors.

### Setup the Windows Program

The Visual Studio solution includes two projects:
- Sunlight simulator: Windows Form application of Sunlight Simulator.
- Sunlight simulator setup: the project that creates the setup for the application.

All the following steps must be performed in the first Visual Studio project:

- Set the RabbitMQ Admin user credentials inside Main.cs.

```c#
Factory = new ConnectionFactory { UserName = "yourusername", Password = "yourpassword", HostName = formIP.IP };
```

- Recompile the entire project and start the program;
- Click on the settings button in the State box;
- Insert the IPv4 address of your Raspberry Pi.

If everything is working, the State should change from "Not connected" to "Connected".

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[GPL-3.0](https://choosealicense.com/licenses/gpl-3.0/)
