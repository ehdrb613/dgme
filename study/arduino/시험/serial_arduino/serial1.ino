#define LED 10
#define BUZZER 12
#include <Servo.h>
int a[] = {0,30,60,90,120,150,180,210,240,270,300,330,360};
Servo servo;  // create servo object to control a servo
int angle = 0;



const int melody[] = {
  262,
  294,
  330,
  349,
  392,
  440,
  494,
  523
};

void setup() {
  //시리얼 통신 속도(baudrate)
  Serial.begin(9600);
  //LED 출력 설정
  pinMode(LED, OUTPUT);
  servo.attach(9);
}

void loop() {
  
  controlSystem();

}


void controlSystem(){
  
    // 데이터 수신: PC -> 아두이노
  if (Serial.available()) {
    char ch = Serial.read();
    if (ch == '1') {
      digitalWrite(LED, HIGH);
      //데이터 송신: 아두이노->PC
      Serial.print("LED ON\n");   
    }
    else if (ch == '2') {
      digitalWrite(LED, LOW);
      Serial.print("LED OFF\n");   
    }
    else if (ch =='3'){
      Serial.print("BUZZER ON\n");
      for(int i=0; i<sizeof(melody)/sizeof(int); i++) {
      tone(BUZZER, melody[i], 200);
      delay(500);
      }
    }
    else if (ch =='4'){
      Serial.print("Servo ON\n"); 
//      for(int i = 0 ; i<7 ; i++){
//        angle = a[i];
//        servo.write(angle);
//        delay(500); 
//      }

      for(angle = 0; angle < 180; angle++) 
      { 
        servo.write(angle); 
        delay(50); 
      } 
      // now scan back from 180 to 0 degrees
      for(angle = 180; angle > 0; angle--) 
      { 
        servo.write(angle); 
        delay(50); 
      } 
            
       
     }
    
    delay(50); 
  }
}
