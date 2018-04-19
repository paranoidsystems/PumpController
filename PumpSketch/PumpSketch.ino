//setup vars
int Pump = 9;           // the PWM pin the Pump is attached to
int PumpPWM = 255;
int incomingByte = 0;
const byte numChars = 32;
char receivedChars[numChars]; // an array to store the received data
boolean newData = false;

void setup() {
// put your setup code here, to run once
//open serial port
Serial.begin(115200);
//setup pins
// declare pin 9 to be an output:
  pinMode(Pump, OUTPUT);  
//start up procedure.
//set PWM to 255 (100%)
  analogWrite(Pump,PumpPWM);
//wait 3 seconds.
  delay(3000);
//set PWM to 153 (60%)
  analogWrite(Pump,153);
//done...off to the loop!
}

void loop() {
// put your main code here, to run repeatedly:
recvWithEndMarker();
//if (receivedChars >= 0 && receivedChars <= 10) {
SetPWM();
//}
ComReply();
}

//recieve string of data
void recvWithEndMarker() {
 static byte ndx = 0;
 char endMarker = '\n';
 char rc;
 
 // if (Serial.available() > 0) {
           while (Serial.available() > 0 && newData == false) {
 rc = Serial.read();

 if (rc != endMarker) {
 receivedChars[ndx] = rc;
 ndx++;
 if (ndx >= numChars) {
 ndx = numChars - 1;
 }
 }
 else {
 receivedChars[ndx] = '\0'; // terminate the string
 ndx = 0;
 newData = true;
 }
 }
}

//reply via serial
void ComReply() {
 if (newData == true) {
 Serial.println(receivedChars);
 Serial.println(PumpPWM);
 newData = false;
 }
}
void SetPWM(){
  PumpPWM = atoi(receivedChars);
  //PumpPWM = map(PumpPWM,0,10,0,255);
  analogWrite(Pump,PumpPWM);
 }
//All auto running features go here. This should be based on info the hardware can get. if any.
  //no code here yet.

