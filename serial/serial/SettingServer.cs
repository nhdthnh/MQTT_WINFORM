using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace serial
{
    
    public partial class SettingServer : Form
    {
        public string espIpAddress;
        public SettingServer()
        {
            InitializeComponent();
            comboPort.DataSource = SerialPort.GetPortNames();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!serialCOM.IsOpen)
            {
                ConnectButton.Text = "Disconnected";
                serialCOM.PortName = comboPort.Text;
                serialCOM.BaudRate = Convert.ToInt32(comboBaud.Text);
                if (string.IsNullOrEmpty(comboPort.Text) || string.IsNullOrEmpty(comboBaud.Text))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                    return;
                }
                ConnectButton.ForeColor = Color.Red;
                serialCOM.Open();
            } 
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            CONTROL form2 = new CONTROL();
            // Hiển thị Form mới
            form2.Show();
   
            // Đóng Form hiện tại nếu cần
            this.Hide();   
        }


        private void SendToESPButton_Click(object sender, EventArgs e)
        {
            string mqttServer = MqttServerTextBox.Text;
            string ssid = ssidText.Text;
            string password = pass.Text;
            if (serialCOM.IsOpen)
            {
                serialCOM.Write(ssid + "\n"); // Gửi giá trị và ký tự Enter
                serialCOM.Write(password + "\n");
                Task.Delay(10000); // Chờ 10 giây
                serialCOM.Write(mqttServer + "\n");
                MessageBox.Show("Thông tin đã được gửi thành công đến ESP32!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                // Kết nối với WiFi ở đây, chỗ này cần thêm mã xử lý kết nối WiFi
                // Sau khi kết nối thành công, lấy địa chỉ IP của thiết bị và hiển thị
                espIpAddress = GetLocalIPAddress();
                MqttServerTextBox.Text = espIpAddress;
            

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

        private void button2_Click(object sender, EventArgs e)
        {
            Main form2 = new Main();
            // Hiển thị Form mới
            form2.Show();

            // Đóng Form hiện tại nếu cần
            this.Hide();
        }
    }
}
