  int sensorPin = A1;
  int sensorValue = 0;
  int count = 0;

void setup() {
  Serial.begin(115200);
  // put your setup code here, to run once:

}

void loop() {
  // put your main code here, to run repeatedly:
  sensorValue = analogRead(sensorPin);
  
  
  if(sensorValue > 500)
  {
      Serial.print("Clear! ");// + sensorValue);
  }
  
  else
  {
    count++;
    Serial.print("Blocked! ");
  }
  
  
 // Serial.print(sensorValue);
  Serial.print("The count is: ");
  Serial.print(count);
  Serial.print('\n');
  delay(2000);
}
