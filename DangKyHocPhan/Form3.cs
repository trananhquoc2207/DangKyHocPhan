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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string tenhv)
        {
            InitializeComponent();
            List<string> ds = new List<string>();
            ds.Add("Trung Hao");
            ds.Add("Cao Sang");
            ds.Add("Ngoc Thanh");
            foreach(string i in ds){
                if (tenhv == i)
                {
                    label_thongbao.Text = "Chao Mung Ban " + tenhv;
                    break;
                }
                else
                {
                    label_thongbao.Text = "Chao Mung Ban " + tenhv ;
                }
                 
            }
           
        }

        private void butquay_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void buttiep_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form2 form2 = new Form2();
                form2.truyendulieu();
                this.Close();
            }
            else if (checkBox2.Checked)
            {
                Form4 atm = new Form4();
                atm.Show();
                this.Close();
            }
            else { MessageBox.Show("Mời bạn chọn hình thức thanh toán!"); }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { checkBox1.Enabled = false; }
            else { checkBox1.Enabled = true; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { checkBox2.Enabled = false; }
            else { checkBox2.Enabled = true; }
        }
    }
}
