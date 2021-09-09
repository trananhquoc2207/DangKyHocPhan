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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvIELTS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void butTieptheo_Click(object sender, EventArgs e)
        {
            Form2 fom2 = new Form2();
            fom2.Show();
           
        }

        private void butTimkiem_Click(object sender, EventArgs e)
        {
            String item = this.comchon.GetItemText(this.comchon.SelectedItem);
            if (item.Equals("1 - TOIEC"))
            {
                lvToiec.Show();
                lvIELTS.Hide();
            }
            if (item.Equals("2 - IELTS"))
            {
                lvIELTS.Show();
                lvToiec.Hide();
            }
        }
    }
}
