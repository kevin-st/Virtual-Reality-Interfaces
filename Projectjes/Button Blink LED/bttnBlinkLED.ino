/*  With a push on the button the LED will turn on/off,
 *  holding it's current state until the button is pressed again
 */

#define LED 13
#define BUTTON 7

bool isLEDOn = false;
bool val, old_val = false;

void setup () {
  pinMode(LED,OUTPUT);
  pinMode(BUTTON, INPUT);
}

void loop (){
  val = digitalRead(BUTTON);
  
  if(val && !old_val) {
    isLEDOn = !isLEDOn;
  }

  old_val = val;
  switchLED(isLEDOn);
}

void switchLED(bool LED_state){
  digitalWrite(LED, LED_state ? HIGH : LOW);
}
