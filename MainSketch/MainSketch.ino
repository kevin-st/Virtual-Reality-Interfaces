// Define each object we use in the alarm system
// and declare it's corresponding Arduino pin
#define CHIME 2
#define DELAY 3
#define ROW1 4
#define ROW2 5
#define ROW3 6
#define ROW4 7
#define COL1 8
#define COL2 9
#define COL3 10
#define PIEZO 11
#define PIR 12
#define LED 13

// Define all Sounds we use in this file
#define NOTE_A3 220
#define NOTE_C4 262
#define NOTE_CS4 277
#define NOTE_AS3 233
#define NOTE_D5 587
#define NOTE_E4 330
#define NOTE_G4 392
#define NOTE_GS4 415
#define NOTE_B2 123
#define NOTE_E3 165

// Include the LiquidCrystal librarie to work with the LCD
#include <LiquidCrystal.h>

// Declare a variable of type LiquidCrystal
// This represents our LCD
LiquidCrystal lcd(15, 14, 19, 18, 17, 16);

// Make two constants (byte) which hold the number of rows
// and columns of our keyPad
const byte numRows = 4;
const byte numCols = 3;

// Declare a 2D array which represents a virtual copy of the keyPad
// This gets as parameters the numRows and numCols values
unsigned char keyMap[numRows][numCols] = {
	{'1','2','3'},
	{'4','5','6'},
	{'7','8','9'},
	{'*','0','#'}
};

// Declare an array which holds all sounds we need for DELAY
int SoundArray[] = {NOTE_A3, NOTE_C4, NOTE_CS4, NOTE_AS3, NOTE_D5, NOTE_E4, NOTE_G4, NOTE_GS4, NOTE_B2, NOTE_E3};

// Declare an array which holds all pressed keys
// Limit it's size to 10, so we cannot adding keys forever
// Here we will store all notes we want to hear
int pressedKeys[10];

// Declare a variable which represents the currentIndex when looping through the array (DELAY)
byte currentIndex = 0;

// Declare another variable we will use to generate random numbers
// This to play random sounds in DELAY
byte randomNumber;

// Declare a variable which holds the number of times we passed the PIR
byte PIR_Counter = 0;

// Declare another variable which holds the value if the PIR is activated or not
boolean locked = true;

// Declare a variable which tells us if the function is running or not
bool isRunning = true;

String bewerkingen[5] = {"Optellen", "Aftrekken", "Vermenigvuldigen", "Delen", "Machten"};
double (*functionArray[5])(double getal1, double getal2);

// Declare a string which holds the current function of the calculator (INSTANT)
// Standard this is equal to Faculteit
String currentState = "Optellen";

// Use this for initialization
void setup(){
  // Start the LCD library by telling how large the LCD is
  // Cols, Rows
  lcd.begin(16, 2);
  
	// Set all rows as INPUT_PULLUP
	for (byte b = ROW1; b <= ROW4; b++)
		pinMode(b, INPUT_PULLUP);
		
	// Set all columns as OUTPUT
	// Make sure they are HIGH so we can't read any values
	for (byte b = COL1; b <= COL3; b++){
		pinMode(b, OUTPUT);
		digitalWrite(b, HIGH);
	}
	
	// Set the LED and PIEZO as OUTPUTS
	// while the PIR, CHIME and DELAY will be INPUT_PULLUP
	pinMode(LED, OUTPUT);
	pinMode(PIEZO, OUTPUT);
	
	pinMode(PIR, INPUT_PULLUP);
	pinMode(CHIME, INPUT_PULLUP);
	pinMode(DELAY, INPUT_PULLUP);

  functionArray[0] = Add;
  functionArray[1] = Subtract;
  functionArray[2] = Multiply;
  functionArray[3] = Divide;
  functionArray[4] = Pow;
 	
	// Use this when analog pin 0 is not used
	// analog noise will cause the call to randomseed() to generate different numbers each time the sketch runs
	//randomSeed(analogRead(0));									                                                                                              //this will shuffle the random function
}

// Here goes code which keeps looping on forever
void loop(){
	while(CheckSwitch() == 1){ 							// Whilst in CHIME mode
		if(scanKeys() != NULL){
			ChimeEXE(scanKeys());
		}
		delay(800);
	};
	
	while(CheckSwitch() == 2){							// Whilst in DELAY
		DelayEXE();
		delay(800);
	};
	
	while(CheckSwitch() == 0){							// While we're running INSTANT
		InstantEXE();
		delay(800);
	};
}

// Here goes the code when in CHIME mode
void ChimeEXE(byte pressedKey){
	for(byte b = 0; b < (pressedKey-'0'); b++){			// Blink the LED as many times as the key we pressed
		BlinkLED();
	}

  while (isRunning){									// While the program is running, we want to keep it running, unless we press * or 0
  	while(scanKeys() == NULL){							// If we don't press any keys
  		// We want the PIR to detect something
		if(detectPIR())
  		{  
			// If it did
  			if(locked)
  			{
				// Unlock it
				locked = false;
				// Let the user know the PIR has detected something by turning on the LED
				digitalWrite(LED, HIGH);
				// Add one to the counter
				PIR_Counter++;
				// And a pause after which we deside there will be no more movement
				delay(10);
  			}
  		}
  		else if(!detectPIR())							// If it didn't detect any movement
  		{
			// Set it's state to lock
  			locked = true;
			// Turn off the LED
  			digitalWrite(LED, LOW);
  		}
  	};
  
    // Whilst we running we want to check if we press *, 0 or #
  	if(scanKeys() == '*'){								// We pressed *
		// Check if the counter is equals to the key we pressed
  		if(PIR_Counter == (pressedKey-'0')){
		    // TADAAAA!!! You've won :D
        WriteToDisplay("You won! :D", 0, "");
        MakeSound(PIEZO, SoundArray[7], 500);
        isRunning = false;
  		}
  		else {
		    // Sorry, you lose
        WriteToDisplay("You lose!", 0, "");
        MakeSound(PIEZO, SoundArray[8], 500);
        isRunning = false;
  		}
  	}
  	else if(scanKeys() == '0'){
		  // set the counter back to zero
      BlinkLED();
      WriteToDisplay("Counter cleared!", 0, "");
      PIR_Counter = 0;
  	}
  	else if(scanKeys() == '#'){
		  // Use this button as a hint
      WriteToDisplay("You passed", 1, (String(PIR_Counter) + " times!"));
      for(byte b = 0; b < PIR_Counter; b++){
        BlinkLED();    
      }
  	}
  };

  // Before quitting ChimeEXE
  // Reset the counter back to 0
  PIR_Counter = 0;
  isRunning = true;
  delay(800);
}

// Here goes the code when in DELAY mode
void DelayEXE(){
	// While running DELAY, we want to check which key we press
	// If it's 0
	if (scanKeys() == '0'){
		// Clear the array
		ClearArray();
    WriteToDisplay("List cleared!", 0, "");
	}
	else if(scanKeys() == '#') 								                                                      // If it's #
	{
		// loop through the array which we added sounds to
		for (byte b = 0; b < 10; b++){
			// Play the current sound with a duration of 250ms
			MakeSound(PIEZO, pressedKeys[b], 250);
			// Put a pause between each sound of 500ms to hear the sounds seperatly
			delay(500);
		}
	}
	else if(scanKeys() == '*'){								                                                      // Else we press *
    // First, clear the array, if there are any elements in it
    ClearArray();
    
		// We want to loop through each element of the pressedKeys
		for (byte b = 0; b < 10; b++){
			// Make a random number 
			randomNumber = random(1, 11);
			// And put it in the pressedKeys array at the current index
			// At this index we add the sound at the random generated index
			pressedKeys[b] = SoundArray[randomNumber];
			
			// Play this sound with a duration of 250ms
			MakeSound(PIEZO, pressedKeys[b], 250);
			// Add a pause between each sound of 500ms to hear them seperatly
			delay(500);
		}
	}
	else {													                                                                // Else we're pressing 1,2,3,4,5,6
		// Check if we pressed a key ourselves (other than 0, #, *)
		// And add the sound to the pressedKeys array
		CheckIfKeyPressed(); 
	}
  delay(800);
}

// Here goes the code when in INSTANT mode
void InstantEXE(){
  byte runTimeScanKeys = 0;     // variable which holds the number of keys we pressed
  byte pressedKey = 0;          // this holds the pressed key, can store different for both get1 and get2
  byte get1 = 0;                // the first factor we use in our equation
  byte get2 = 0;                // the second factor we use

  // First we want to check if we pressed a key
  // if not, we don't want the whole code to run
  if(scanKeys() != NULL){
    for (byte b = 0; b < 5; b++) {
        if(currentState == bewerkingen[b]){                                           // check in which state we are (which method do we need to call?)
          while(runTimeScanKeys < 2){                                                 // we want to be able to give two (different) factors and store these both in get1 as well as get2
            if(scanKeys() != NULL && scanKeys() != '*' && scanKeys() != '#'){         // as long as we didn't press '*' or '#', we want to add numbers to get1 and get2
              pressedKey = scanKeys();
              BlinkLED();                                                             // blink the LED when we pressed a key so we know the keypress is processed
              WriteToDisplay("Pressed: ", 0, "");
              lcd.write(pressedKey);
  
              if (runTimeScanKeys == 0){
                get1 = pressedKey-'0';
                ++runTimeScanKeys;
                pressedKey = NULL;                                                    // set pressedkey back to NULL so we don't add the same number to get2 automatically
              }
              else {
                get2 = pressedKey-'0';
                ++runTimeScanKeys;
              }
            }
            else if (scanKeys() == '*'){                                              // when we pressed '*'
              BlinkLED();                                                             // Blink the LED so we know the key is processed
              CurrentInstantFunction();                                               // switch between the different functions of the calculator
            }
            else if(scanKeys() == '#'){
              runTimeScanKeys = 0;
              get1 = 0;
              get2 = 0;
              WriteToDisplay("Cleared!", 0, "");
            }
            
            delay(800);
          };
  
          double answer = (*functionArray[b])(get1, get2);                            // Call the function in the functionArray at the current index with parameters get1 and get2
          
          WriteToDisplay("Antwoord: ", 1, String(answer));                            // Then write the the answer to the LCD screen
        }
      }
  }

  delay(800);
}

// Use this to check in which position the switch is
byte CheckSwitch(){
	if(!digitalRead(CHIME)){
		WriteToDisplay("Switched to: ", 1, "CHIME");
		return 1;
	}
	else if(!digitalRead(DELAY)){
		WriteToDisplay("Switched to: ", 1, "DELAY");
		return 2;
	}
	else
  {
    WriteToDisplay("Switched to: ", 1, "INSTANT");
		return 0;
  }
}

// Use this method to blink the led
void BlinkLED(){
	digitalWrite(LED, HIGH);
	delay(500);
	digitalWrite(LED, LOW);
	delay(500);
}

// Use this method to scan the keypad for any pressed keys
unsigned char scanKeys(){
	// Return nothing when no key has been pressed
	char toets = NULL;
	
	byte curCol = 0;								// Counter which holds the current column we're scanning
	byte curRow;									// Counter which holds the current row we're scanning

	for (byte b = COL1; b <= COL3; b++){
		digitalWrite(b, LOW);
		curRow = 0;
		
		for(byte a = ROW1; a <= ROW4; a++){
			if(digitalRead(a) == LOW){
				toets = keyMap[curRow][curCol];
			}
			curRow++;
		}
		
		curCol++;
		digitalWrite(b, HIGH);
	}
	
	return toets;
} 


// Write a method which checks if a key is pressed
// If so, we let the user know by turning on the LED.		DELAY
void CheckIfKeyPressed(){
	// Check if the key which is returned is not equal to null
	if(scanKeys() != NULL)
	{
		if (currentIndex < 10){
			// Add the key to the current index in the array
			pressedKeys[currentIndex] = SoundArray[scanKeys()-'0'];
      // Let hear a 'good' sound which lets the user know the key is registered
      MakeSound(PIEZO, SoundArray[scanKeys()-'0'], 450);
      // If so we want to blink the LED
      BlinkLED();
			// Add 1 to the current index so the next we run this, we are not changing the previous variable
			currentIndex++;
		}
		else {
			// When the currentIndex >= 10, we want to hear a wrong sound
			// without doing anything else.
			// So the user knows the key can't be added to the array
			MakeSound(PIEZO, NOTE_E3, 500);
		}
	}
}

// Use this methoud to clear the pressedKeys array
// containing all pressed keys when we're in DELAY
void ClearArray(){
	// Make sure we pressed a key
	if (pressedKeys != NULL){
		// Set all data in the array to 0
		memset(pressedKeys, NULL, sizeof(pressedKeys));
		// Set the currentIndex back to 0, so we can add keys to the array again
		currentIndex = 0;
		// Let hear a sound, so the user knows the array is empty
		MakeSound(PIEZO, NOTE_D5, 250);
	}
}

// Use this method to warn the user when the array is cleared		DELAY
void MakeSound(byte pin, int note, int duration){
	tone(pin, note, duration);
}

boolean detectPIR(){
	if(!digitalRead(PIR)) {
		return true; 
	}
	  
	return false;
}

// Use this method to calculate the factorial of a number
int Factorial(int number){
  if(number == 1)
    return 1;

  return number * Factorial(number - 1);
}

void CurrentInstantFunction(){
  lcd.clear();

  for(byte i = 0; i < 5; i++){
    if(currentState == bewerkingen[i]){     
      if(i == 4){
        lcd.print(bewerkingen[0]);
        currentState = bewerkingen[0];
      }
      else {
        lcd.print(bewerkingen[++i]);
        currentState = bewerkingen[i++];
      }
    }
  }
}

double Add(double g1, double g2){
  return g1 + g2;
}

double Subtract(double g1, double g2){
  return g1 - g2;
}

double Multiply(double g1, double g2){
  return g1 * g2;
}

double Divide(double g1, double g2){
  if(g2 == 0)
  {
    WriteToDisplay("Can't divide by", 1, "");
    return 0;
  }
  else {
    return g1/g2;
  }
}

double Pow(double g1, double g2){
  return pow(g1, g2);
}

void WriteToDisplay(String message1, bool enterNextLine, String message2){
  lcd.clear();
  lcd.print(message1);

  if(enterNextLine){
    lcd.setCursor(0, 1);
    lcd.print(message2);
  }
}

