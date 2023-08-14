using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;

namespace serial
{
    public partial class CONTROL : Form
    {
        private MqttClient mqttClient;

        public CONTROL()
        {
            InitializeComponent();
        }
        private string GetLocalIPAddress()
        {
            string ipAddress = "";
            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && netInterface.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ipInfo in netInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (ipInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipAddress = ipInfo.Address.ToString();
                            break;
                        }
                    }
                }
            }
            return ipAddress;
        }
        private void CONTROL_Load(object sender, EventArgs e)
        {
            string brokerAddress = GetLocalIPAddress();
            InitializeMqtt(brokerAddress);
            MqttServerLabel.Text = brokerAddress;
            mqttClient.Subscribe(new string[] { "sensor/temperature", "sensor/humidity" },
          new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

        }

        private void InitializeMqtt(string brokerAddress)
        {
            mqttClient = new MqttClient(brokerAddress);
            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            string clientId = Guid.NewGuid().ToString();
            mqttClient.Connect(clientId);

            if (mqttClient.IsConnected)
            {
                MessageBox.Show("Kết nối MQTT thành công!");

            }
            else
            {
                MessageBox.Show("Kết nối MQTT thất bại!");
            }
        }
        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string message = Encoding.UTF8.GetString(e.Message);
            // Xử lý tin nhắn nhận được từ MQTT server (nếu cần)
            string topic = e.Topic;
            // Xử lý dữ liệu nhận được từ MQTT
            if (topic == "sensor/temperature")
            {
                // Hiển thị nhiệt độ trên label
                this.Invoke(new Action(() =>
                {
                    temperatureLabel.Text = "Nhiệt độ: " + message + " °C";
                }));
                this.Invoke(new Action(() =>
                {
                    if (double.TryParse(message, out double value))
                    {
                        chart1.Series["Nhiet Do"].Points.AddY(value);
                    }
                    else
                    {
                        // Xử lý trường hợp không thể chuyển đổi thành số hợp lệ
                    }
                }));
            }
            else if (topic == "sensor/humidity")
            {
                // Hiển thị độ ẩm trên label
                this.Invoke(new Action(() =>
                {
                    humidityLabel.Text = "Độ ẩm: " + message + " %";
                }));

                // Thêm giá trị độ ẩm vào chart
                this.Invoke(new Action(() =>
                {
                    if (double.TryParse(message, out double value))
                    {
                        chart.Series["Do Am"].Points.AddY(value);
                    }
                    else
                    {
                        // Xử lý trường hợp không thể chuyển đổi thành số hợp lệ
                    }
                }));

            }
        }
        private void SendMqttMessage(string message)
        {
            if (mqttClient.IsConnected)
            {
                mqttClient.Publish("led/control", Encoding.UTF8.GetBytes(message));
            }
            else
            {
                MessageBox.Show("Không thể gửi tin nhắn MQTT vì kết nối chưa được thiết lập.");
            }
        }

        bool x = false;
        private void OnButton_Click_1(object sender, EventArgs e)
        {
            if (x == true)
            {
                SendMqttMessage("B1");
                OnButton.BackColor = Color.Red;
                x = false;
                OnButton.Text = "OFF";
                label1.Text = "Thiết bị 1 đã bật";
            }
            else if (x == false)
            {
                OnButton.Text = "ON";
                SendMqttMessage("T1");
                OnButton.BackColor = Color.Green;
                x = true;
                label1.Text = "Thiết bị 1 đã tắt";
            }


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Main form2 = new Main();
            // Hiển thị Form mới
            form2.Show();

            // Đóng Form hiện tại nếu cần
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
