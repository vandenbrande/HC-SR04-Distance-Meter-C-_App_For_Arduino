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
