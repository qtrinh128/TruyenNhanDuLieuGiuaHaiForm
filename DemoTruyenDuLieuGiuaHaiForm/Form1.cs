using System;
using System.Windows.Forms;

namespace DemoTruyenDuLieuGiuaHaiForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        // Khởi tạo delegate gui du lieu sang form 2
        public delegate void SendDataToForm2(string name);
        public SendDataToForm2 sendDataToForm2;

        public void GetValue(string data)
        {
            txtF1.Text = data;
        }
        private void bntF1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.sendDataToForm2 += new SendDataToForm2(f2.GetData);
            sendDataToForm2(txtF1.Text);
            f2.Show();
        }
    }
}
