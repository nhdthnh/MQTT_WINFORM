﻿namespace serial
{
    partial class Main
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
            this.ControlOpen = new System.Windows.Forms.Button();
            this.ServerOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ControlOpen
            // 
            this.ControlOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlOpen.Location = new System.Drawing.Point(270, 12);
            this.ControlOpen.Name = "ControlOpen";
            this.ControlOpen.Size = new System.Drawing.Size(257, 128);
            this.ControlOpen.TabIndex = 0;
            this.ControlOpen.Text = "Control";
            this.ControlOpen.UseVisualStyleBackColor = true;
            this.ControlOpen.Click += new System.EventHandler(this.ControlOpen_Click);
            // 
            // ServerOpen
            // 
            this.ServerOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerOpen.Location = new System.Drawing.Point(272, 161);
            this.ServerOpen.Name = "ServerOpen";
            this.ServerOpen.Size = new System.Drawing.Size(257, 128);
            this.ServerOpen.TabIndex = 1;
            this.ServerOpen.Text = "Server Setting";
            this.ServerOpen.UseVisualStyleBackColor = true;
            this.ServerOpen.Click += new System.EventHandler(this.ServerOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhu Dinh Thanh";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerOpen);
            this.Controls.Add(this.ControlOpen);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ControlOpen;
        private System.Windows.Forms.Button ServerOpen;
        private System.Windows.Forms.Label label1;
    }
}