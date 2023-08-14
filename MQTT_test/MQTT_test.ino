#include <WiFi.h>
#include <PubSubClient.h>

const char* ssid = "";       // Tên mạng WiFi
const char* password = "";   // Mật khẩu WiFi
const int mqttPort = 1883;             // Cổng MQTT
const char* mqttUser = "";     // Tên đăng nhập MQTT
const char* mqttPassword = "";      // Mật khẩu MQTT

const int ledPin = 2;  // Chân GPIO để kết nối với LED
char command;          // Biến để lưu dữ liệu từ cổng Serial
String mqttServer = ""; // Biến để lưu địa chỉ MQTT broker

WiFiClient espClient;
PubSubClient client(espClient);
#include <DHT.h>

DHT dht(4, DHT11);           // Khởi tạo cảm biến DHT11 kết nối với chân GPIO 4
void setup() {
  Serial.begin(9600); // Khởi tạo cổng Serial với tốc độ 9600 bps
  pinMode(ledPin, OUTPUT); // Đặt chân GPIO cho LED là OUTPUT
  digitalWrite(ledPin, LOW); // Tắt LED ban đầu

  // Đọc tên mạng WiFi từ Serial Monitor
  Serial.println("Nhập tên mạng WiFi (SSID):");
  while (Serial.available() == 0) {
    delay(100); // Chờ cho đến khi có dữ liệu từ Serial Monitor
  }
  String ssid = Serial.readStringUntil('\n');
  ssid.trim();

  // Đọc mật khẩu WiFi từ Serial Monitor
  Serial.println("Nhập mật khẩu WiFi:");
  while (Serial.available() == 0) {
    delay(100); // Chờ cho đến khi có dữ liệu từ Serial Monitor
  }
  String password = Serial.readStringUntil('\n');
  password.trim();

  // Kết nối WiFi
  WiFi.begin(ssid.c_str(), password.c_str());
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Đang kết nối đến WiFi...");
  }
  Serial.println("Đã kết nối đến WiFi");

  // Đọc địa chỉ MQTT broker từ Serial Monitor
  Serial.println("Nhập địa chỉ MQTT broker:");
  while (Serial.available() == 0) {
    delay(100); // Chờ cho đến khi có dữ liệu từ Serial Monitor
  }
  mqttServer = Serial.readStringUntil('\n');
  mqttServer.trim();

  // Kết nối tới MQTT broker và các cài đặt khác
  client.setServer(mqttServer.c_str(), 1883); // Sử dụng cổng MQTT mặc định
  client.setCallback(callback);

  // Kết nối đến MQTT broker
  while (!client.connected()) {
    if (client.connect("ESP32Client")) {
      Serial.println("Đã kết nối đến MQTT broker");
      digitalWrite(ledPin, HIGH);
      client.subscribe("led/control"); // Đăng ký theo dõi chủ đề MQTT
    } else {
      Serial.print("Kết nối thất bại, trạng thái: ");
      Serial.print(client.state());
      delay(2000);
    }
  }
}

void loop() {
  if (!client.connected()) {
    reconnect();
  }
  client.loop();
  float humidity = dht.readHumidity();
  float temperature = dht.readTemperature();

  // Gửi dữ liệu nhiệt độ và độ ẩm qua MQTT
  String tempStr = String(temperature);
  String humStr = String(humidity);

  client.publish("sensor/temperature", tempStr.c_str());
  client.publish("sensor/humidity", humStr.c_str());
}

void callback(char* topic, byte* payload, int length) {
  String data = "";
  for (int i = 0; i < length; i++) {
    data += (char)payload[i];
  }
  data.trim();
  if (data == "B1") {
    digitalWrite(ledPin, HIGH); // Bật LED
    Serial.println("LED đã được bật");
  } else if (data == "T1") {
    digitalWrite(ledPin, LOW);  // Tắt LED
    Serial.println("LED đã được tắt");
  }
}

void reconnect() {
  while (!client.connected()) {
    if (client.connect("ESP32Client", mqttUser, mqttPassword)) {
      Serial.println("Connected to MQTT broker");
      client.subscribe("led-control"); // Đăng ký theo dõi chủ đề MQTT
    } else {
      Serial.print("Failed with state ");
      Serial.print(client.state());
      delay(2000);
    }
  }
}
