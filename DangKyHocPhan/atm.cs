using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class atm : Form
    {
        public atm()
        {
            InitializeComponent();
        }
        public atm(string tenhv, string sinh, string sdt, string email)
        {
            InitializeComponent();
            textBox_TenHV.Text = tenhv;
            textBox_Sinh.Text = sinh;
            textBox_Sdt.Text = sdt;
            textBox_Email.Text = email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
