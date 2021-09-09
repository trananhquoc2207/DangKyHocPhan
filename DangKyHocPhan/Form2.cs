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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }
        public Form2(string a, string b, string c, string d, string g)
        {
            InitializeComponent();
            textBox_tenkh.Text = a;
            textBox_mucdiem.Text = b;
            textBox_hocphi.Text = c;
            textBox_tgbatdau.Text = d;
            textBox_tgketthuc.Text = g;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void buttiep_Click(object sender, EventArgs e)
        {
            if(textBox_TenHV.Text=="" || textBox_Sinh.Text == "" || textBox_Email.Text == "" || textBox_Sdt.Text == "" || checkBox1.Checked==false && checkBox2.Checked == false)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
               
            }
            else
            {
               
                string tenhv = textBox_TenHV.Text;
                Form3 fom3 = new Form3(tenhv);
                fom3.Show();

                
                this.Close();
            }
            
        }

        
        public void truyendulieu()
        {
            string tenhv = textBox_TenHV.Text;
            string sinh = textBox_Sinh.Text;
            string sdt = textBox_Sdt.Text;
            string email = textBox_Email.Text;
            tienmat tienmat = new tienmat(tenhv, sinh, sdt, email);
            tienmat.Show();
        }

        public void truyendulieuatm()
        {
            string tenhv = textBox_TenHV.Text;
            string sinh = textBox_Sinh.Text;
            string sdt = textBox_Sdt.Text;
            string email = textBox_Email.Text;
            atm atm = new atm(tenhv, sinh, sdt, email);
            atm.Show();
        }

        private void butquay_Click(object sender, EventArgs e)
        {
            Form1 fom1 = new Form1();
            fom1.Show();
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { checkBox2.Enabled = false; }
            else { checkBox2.Enabled = true; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { checkBox1.Enabled = false; }
            else { checkBox1.Enabled = true; }
        }
    }
}
