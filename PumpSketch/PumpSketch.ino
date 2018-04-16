//setup vars
int Pump = 9;           // the PWM pin the Pump is attached to

void setup() {
// put your setup code here, to run once:
//open serial port
Serial.begin(9600);
//setup pins
// declare pin 9 to be an output:
  pinMode(Pump, OUTPUT);  
//start up procedure.
//set PWM to 255 (100%)
  analogWrite(Pump,255);
//wait 3 seconds.
  delay(3000);
//set PWM to 153 (60%)
  analogWrite(Pump,255);
//done...off to the loop!
}

void loop() {
// put your main code here, to run repeatedly:
//read serial, this is speed overide currently
// send data only when you receive data:
        if (Serial.available() > 0) {
                // read the incoming byte:
                incomingByte = Serial.read();

                // say what you got:
                Serial.print("I received: ");
                Serial.println(incomingByte, DEC);
                //set fan speed to data that was sent
                analogWrite(Pump,incomingByte);

//read speed signal from pump
  
}
