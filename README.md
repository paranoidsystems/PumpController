# PumpController
PWM pump controller for 12v pump.

This came from an issue I had. At 100% my pump is very noisy as it's powerful enough to pull in air bubbles,
but at 5v it's not always enough to start the pump from a stand still. So I wanted to run the pump at 12v for a few seconds 
then ramp down to 6v or so. I was going to use a timer relay but then i thought I could add some features if I use a nano.
So the pump controller was born. I wnt to pass through the speed to the motheroard and perhpas be able to ramp up the pump under load.

nano controlled pump controller. 

parts I used
Nano of your choice
Mosfet setup (cheap mosfet boards are everywhere on ebay/amazon)
3 pin Fan cable
Header rows

code flow

