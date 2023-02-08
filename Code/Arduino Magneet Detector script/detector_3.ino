int hallSensorPin = A2; 
int hallSensorPin2 = A3;
int hallSensorPin3 = A4;

int state = 0;
int state2 = 0;
int state3 = 0;

void setup() {
  pinMode(hallSensorPin, INPUT);
  pinMode(hallSensorPin2, INPUT);
  pinMode(hallSensorPin3, INPUT);
  Serial.begin(115200);
}

void loop() {
  state = analogRead(hallSensorPin);
  state2 = analogRead(hallSensorPin2);
  state3 = analogRead(hallSensorPin3);

  if (state > 700 && state2 > 700 && state3 > 700) {
    Serial.println("State hoger dan 700");
  }
  else if (state < 500 && state2 < 500 && state3 < 500) {
    Serial.println("lager dan 500");
  }
  delay(1000);
}
