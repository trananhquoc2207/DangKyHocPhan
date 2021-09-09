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
                tienmat tm = new tienmat();
                tm.Show();
           
                this.Close();
            }
            else
            {
                Form4 atm = new Form4();
                atm.Show();
             
                this.Close();
            }
        }
    }
}
