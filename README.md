# HC-SR04-Distance-Meter-C-_App_For_Arduino
Windows application to read the value from a sensor, in this case the HC-sr04 Ultrasonic sensor. You can add any sensor and display the value by sending the value from arduino to serial COM port, You can use any sensor for this app.

Hello world! Today i made a C# App For Arduino to display The distance with a HC-SR04 Ultrasonic sensor, The code is very simple and you could also use the app for other sensors to display a value by simply sending the value to serial Serial.println(distance); or whatever you name your value, so if you wanna display temperature you can simply display temperature on this app by sending the value from arduino to the serial.
Files you modify in the C# source are the following. Form1.cs & Form.1Designer.cs To modify the look of the Application you simply double click on Form1.cs and the Form1.cs [Design] should pop up. You can now drag and drop buttons and whatever you want from the toolbox, and change background in the properties etc. If adding a button for example, double click the button to give it a function, Double clicking it will bring you to the part of the code that belongs to the button.
You can also change the about box by double clicking on the about box AboutBox1.cs, You can change background, font, colors etc. To change company name, version etc. you can double click Properties in the [solution explorer]. And then at [application] click on [assembly information], you can also modify AssemblyInfo.cs directly.

Arduino code below.

#define echo 8
#define trigger 9
long duration,distance;

void setup() {
 Serial.begin (9600);
 pinMode(trigger, OUTPUT);
 pinMode(echo, INPUT);
 digitalWrite(trigger, LOW); 
}

void loop() {
 digitalWrite(trigger, LOW); 
 digitalWrite(trigger, HIGH);
 delayMicroseconds(10); 
 digitalWrite(trigger, LOW);
 duration = pulseIn(echo, HIGH);
 distance = duration/58;
 if ((distance >= 400) || (distance <= 2))
 distance = -1;
 Serial.println(distance);
 delay(60);
  
}
