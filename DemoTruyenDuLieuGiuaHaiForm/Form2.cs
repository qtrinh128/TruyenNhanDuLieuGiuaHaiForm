using System;
using System.Windows.Forms;

namespace DemoTruyenDuLieuGiuaHaiForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void GetData(string name)
        {
            txtF2.Text = name;
        }
    }
}
