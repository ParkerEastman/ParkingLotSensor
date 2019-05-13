  int sensorPin = A1;
  int sensorValue = 0;

void setup() {
  Serial.begin(115200);
  // put your setup code here, to run once:

}

void loop() {
  // put your main code here, to run repeatedly:
  sensorValue = analogRead(sensorPin);
  
  
  if(sensorValue > 500)
  {
      Serial.print("Clear");// + sensorValue);
  }
  
  else
  {
    Serial.print("Blocked");// + sensorValue);
  }
  
  
 // Serial.print(sensorValue);
  Serial.print('\n');
  delay(2000);
}
