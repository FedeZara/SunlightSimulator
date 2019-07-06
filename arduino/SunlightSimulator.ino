#include <DmxSimple.h>

int potenze[6];
void setup() {
  Serial.begin(9600);
  DmxSimple.maxChannel(512);
}

void loop() {
  // put your main code here, to run repeatedly:
  
}

String stringa;
void serialEvent(){
  char c = Serial.read();
  if(c == 'f'){
    char cmd = stringa[0];
    stringa = stringa.substring(1);
    switch(cmd){
      case '1':
      case '2':
      case '3':
      case '4':
      case '5':
      case '6':
      {
        int faro = cmd-'0';
        Serial.print(faro);
        int potenza = stringa.toInt();
        potenze[faro-1] = potenza;
        Serial.print(potenza);
        DmxSimple.write(faro, potenza);
        break;
      }
        
      case 'a':
      {
        int potenza = stringa.toInt();
        for(int i=0; i<6; i++){
          potenze[i] = potenza;
          DmxSimple.write(i+1, potenza);
        }
        break;
        
      }
       
    }
    stringa = "";
  }
  else{
    stringa += c;
  }
  
  /*
  
  /*
  for(int i=0; i<6; i++){
        DmxSimple.write(i+1, stringa.toInt());
        Serial.write(stringa.toInt());
      }*/
}


