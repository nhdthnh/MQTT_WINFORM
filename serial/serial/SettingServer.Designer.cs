namespace serial
{
    partial class SettingServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.serialCOM = new System.IO.Ports.SerialPort(this.components);
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.GetWiFiIPButton = new System.Windows.Forms.Button();
            this.MqttServerTextBox = new System.Windows.Forms.TextBox();
            this.ssidText = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.Color.Black;
            this.ConnectButton.Location = new System.Drawing.Point(13, 333);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(232, 73);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "COM Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(788, 356);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 47);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(178, 42);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(192, 37);
            this.comboPort.TabIndex = 4;
            // 
            // comboBaud
            // 
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "9600",
            "11520"});
            this.comboBaud.Location = new System.Drawing.Point(178, 98);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(192, 37);
            this.comboBaud.TabIndex = 5;
            // 
            // GetWiFiIPButton
            // 
            this.GetWiFiIPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetWiFiIPButton.ForeColor = System.Drawing.Color.Green;
            this.GetWiFiIPButton.Location = new System.Drawing.Point(448, 333);
            this.GetWiFiIPButton.Name = "GetWiFiIPButton";
            this.GetWiFiIPButton.Size = new System.Drawing.Size(148, 73);
            this.GetWiFiIPButton.TabIndex = 6;
            this.GetWiFiIPButton.Text = "MQTT CONNECT";
            this.GetWiFiIPButton.UseVisualStyleBackColor = true;
            this.GetWiFiIPButton.Click += new System.EventHandler(this.SendToESPButton_Click);
            // 
            // MqttServerTextBox
            // 
            this.MqttServerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MqttServerTextBox.Location = new System.Drawing.Point(207, 161);
            this.MqttServerTextBox.Name = "MqttServerTextBox";
            this.MqttServerTextBox.Size = new System.Drawing.Size(269, 30);
            this.MqttServerTextBox.TabIndex = 7;
            // 
            // ssidText
            // 
            this.ssidText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssidText.Location = new System.Drawing.Point(207, 23);
            this.ssidText.Name = "ssidText";
            this.ssidText.Size = new System.Drawing.Size(269, 30);
            this.ssidText.TabIndex = 8;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(207, 94);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(269, 30);
            this.pass.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "SSID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "MQTT SERVER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "COM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "BAUDRATE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBaud);
            this.groupBox1.Controls.Add(this.comboPort);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(525, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 162);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Serial Com";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(265, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 73);
            this.button1.TabIndex = 16;
            this.button1.Text = "Get IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(710, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "NhuDinhThanh";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "⬅";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(931, 510);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.ssidText);
            this.Controls.Add(this.MqttServerTextBox);
            this.Controls.Add(this.GetWiFiIPButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ConnectButton);
            this.Name = "SettingServer";
            this.Text = "Setting Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button Exit;
        private System.IO.Ports.SerialPort serialCOM;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.Button GetWiFiIPButton;
        private System.Windows.Forms.TextBox MqttServerTextBox;
        private System.Windows.Forms.TextBox ssidText;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

