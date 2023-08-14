namespace serial
{
    partial class CONTROL
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.OnButton = new System.Windows.Forms.Button();
            this.MqttServerLabel = new System.Windows.Forms.Label();
            this.Device1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Device2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OnButton2 = new System.Windows.Forms.Button();
            this.Device3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OnButton3 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.Device1.SuspendLayout();
            this.Device2.SuspendLayout();
            this.Device3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // OnButton
            // 
            this.OnButton.BackColor = System.Drawing.Color.Green;
            this.OnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnButton.Location = new System.Drawing.Point(6, 29);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(124, 74);
            this.OnButton.TabIndex = 3;
            this.OnButton.Text = "ON";
            this.OnButton.UseVisualStyleBackColor = false;
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click_1);
            // 
            // MqttServerLabel
            // 
            this.MqttServerLabel.AutoSize = true;
            this.MqttServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MqttServerLabel.Location = new System.Drawing.Point(12, 9);
            this.MqttServerLabel.Name = "MqttServerLabel";
            this.MqttServerLabel.Size = new System.Drawing.Size(42, 32);
            this.MqttServerLabel.TabIndex = 1;
            this.MqttServerLabel.Text = "IP";
            // 
            // Device1
            // 
            this.Device1.BackColor = System.Drawing.Color.PeachPuff;
            this.Device1.Controls.Add(this.label1);
            this.Device1.Controls.Add(this.OnButton);
            this.Device1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Device1.Location = new System.Drawing.Point(12, 45);
            this.Device1.Name = "Device1";
            this.Device1.Size = new System.Drawing.Size(319, 118);
            this.Device1.TabIndex = 4;
            this.Device1.TabStop = false;
            this.Device1.Text = "Thiết bị 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(136, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thiết bị 1 đã tắt";
            // 
            // Device2
            // 
            this.Device2.BackColor = System.Drawing.Color.LightCoral;
            this.Device2.Controls.Add(this.label2);
            this.Device2.Controls.Add(this.OnButton2);
            this.Device2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Device2.Location = new System.Drawing.Point(12, 199);
            this.Device2.Name = "Device2";
            this.Device2.Size = new System.Drawing.Size(319, 118);
            this.Device2.TabIndex = 5;
            this.Device2.TabStop = false;
            this.Device2.Text = "Thiết bị 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(136, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thiết bị 2 đã tắt";
            // 
            // OnButton2
            // 
            this.OnButton2.BackColor = System.Drawing.Color.Green;
            this.OnButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnButton2.Location = new System.Drawing.Point(6, 29);
            this.OnButton2.Name = "OnButton2";
            this.OnButton2.Size = new System.Drawing.Size(124, 74);
            this.OnButton2.TabIndex = 3;
            this.OnButton2.Text = "ON";
            this.OnButton2.UseVisualStyleBackColor = false;
            // 
            // Device3
            // 
            this.Device3.BackColor = System.Drawing.Color.RosyBrown;
            this.Device3.Controls.Add(this.label3);
            this.Device3.Controls.Add(this.OnButton3);
            this.Device3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Device3.Location = new System.Drawing.Point(12, 356);
            this.Device3.Name = "Device3";
            this.Device3.Size = new System.Drawing.Size(319, 118);
            this.Device3.TabIndex = 6;
            this.Device3.TabStop = false;
            this.Device3.Text = "Thiết bị 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(136, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thiết bị 3 đã tắt";
            // 
            // OnButton3
            // 
            this.OnButton3.BackColor = System.Drawing.Color.Green;
            this.OnButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnButton3.Location = new System.Drawing.Point(6, 29);
            this.OnButton3.Name = "OnButton3";
            this.OnButton3.Size = new System.Drawing.Size(124, 74);
            this.OnButton3.TabIndex = 3;
            this.OnButton3.Text = "ON";
            this.OnButton3.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.Location = new System.Drawing.Point(12, 492);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 49);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "⬅";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temperatureLabel.Location = new System.Drawing.Point(396, 45);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(110, 36);
            this.temperatureLabel.TabIndex = 8;
            this.temperatureLabel.Text = "Sensor";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.humidityLabel.Location = new System.Drawing.Point(396, 127);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(110, 36);
            this.humidityLabel.TabIndex = 9;
            this.humidityLabel.Text = "Sensor";
            // 
            // chart
            // 
            chartArea7.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea7);
            this.chart.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            legend7.Name = "Legend1";
            this.chart.Legends.Add(legend7);
            this.chart.Location = new System.Drawing.Point(402, 187);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Do Am";
            this.chart.Series.Add(series7);
            this.chart.Size = new System.Drawing.Size(703, 300);
            this.chart.TabIndex = 10;
            this.chart.TabStop = false;
            this.chart.Text = "Sensor";
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(402, 518);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Nhiet Do";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(703, 300);
            this.chart1.TabIndex = 11;
            this.chart1.TabStop = false;
            this.chart1.Text = "Sensor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(893, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nhu Dinh Thanh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CONTROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 878);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Device3);
            this.Controls.Add(this.Device2);
            this.Controls.Add(this.Device1);
            this.Controls.Add(this.MqttServerLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "CONTROL";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.CONTROL_Load);
            this.Device1.ResumeLayout(false);
            this.Device1.PerformLayout();
            this.Device2.ResumeLayout(false);
            this.Device2.PerformLayout();
            this.Device3.ResumeLayout(false);
            this.Device3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OnButton;
        private System.Windows.Forms.Label MqttServerLabel;
        private System.Windows.Forms.GroupBox Device1;
        private System.Windows.Forms.GroupBox Device2;
        private System.Windows.Forms.Button OnButton2;
        private System.Windows.Forms.GroupBox Device3;
        private System.Windows.Forms.Button OnButton3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
    }
}