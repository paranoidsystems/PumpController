//setup vars
int Pump = 9;           // the PWM pin the Pump is attached to

void setup() {
  // put your setup code here, to run once:
  //setup pins
   // declare pin 9 to be an output:
  pinMode(Pump, OUTPUT);  
  //start up procedure.
  //set PWM to 255 (100%)
  analogWrite(Pump,255);
  delay(3000);
  //wait 3 seconds.
  //set PWM to 153 (60%)
  analogWrite(Pump,255);
  //done...off to the loop!
}

void loop() {
  // put your main code here, to run repeatedly:
  //read speed signal from pump
  
}
