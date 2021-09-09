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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttiep_Click(object sender, EventArgs e)
        {
            Form3 fom2 = new Form3();
            fom2.Show();
            Form2 fom1 = new Form2();
            this.Close();
        }

        private void butquay_Click(object sender, EventArgs e)
        {
            Form1 fom1 = new Form1();
            fom1.Show();
            this.Close();

        }
    }
}
