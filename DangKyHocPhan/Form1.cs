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
         string a, b, c, d, g;

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

        private void lvIELTS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void butTieptheo_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lvIELTS.Items.Count ;i++ ){
                 if (lvIELTS.Items[i].Checked)
                {
                    a = lvIELTS.Items[i].SubItems[1].Text;
                    b = lvIELTS.Items[i].SubItems[2].Text;
                    c = lvIELTS.Items[i].SubItems[5].Text;
                    d = lvIELTS.Items[i].SubItems[3].Text;
                    g = lvIELTS.Items[i].SubItems[4].Text;
                   
                }               
            }
            for (int i = 0; i < lvToiec.Items.Count; i++)
            {
                if (lvToiec.Items[i].Checked)
                {
                    a = lvToiec.Items[i].SubItems[1].Text;
                    b = lvToiec.Items[i].SubItems[2].Text;
                    c = lvToiec.Items[i].SubItems[5].Text;
                    d = lvToiec.Items[i].SubItems[3].Text;
                    g = lvToiec.Items[i].SubItems[4].Text;
                    
                }
            }
            if (checkBox1.Checked)
            {
                Form2 fom2 = new Form2(a, b, c, d, g);
                fom2.Show();
                this.Hide();
            }
            else if (checkBox2.Checked)
            {
                hvc hvc = new hvc();
                hvc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mời bạn xác nhận!");
            }
            
               
        }

        private void butTimkiem_Click(object sender, EventArgs e)
        {
            String item = this.comchon.GetItemText(this.comchon.SelectedItem);
            if (item.Equals("1 - TOIEC"))
            {
                lvToiec.Show();
                lvIELTS.Hide();
                listView1.Hide();
            }
            if (item.Equals("2 - IELTS"))
            {
                lvIELTS.Show();
                lvToiec.Hide();
                listView1.Hide();
            }
        }

        
    }
}
