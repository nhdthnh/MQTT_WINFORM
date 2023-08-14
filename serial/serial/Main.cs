using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serial
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ControlOpen_Click(object sender, EventArgs e)
        {
            CONTROL form2 = new CONTROL();
            // Hiển thị Form mới
            form2.Show();

            // Đóng Form hiện tại nếu cần
            this.Hide();
        }

        private void ServerOpen_Click(object sender, EventArgs e)
        {
            SettingServer form2 = new SettingServer();
            // Hiển thị Form mới
            form2.Show();

            // Đóng Form hiện tại nếu cần
            this.Hide();
        }
    }
}
