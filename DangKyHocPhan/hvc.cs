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
    public partial class hvc : Form
    {
        public hvc()
        {
            InitializeComponent();
        }
        
        private void button_loc_Click(object sender, EventArgs e)
        {
            if(textBox_sdt.Text == "012345678")
            {
                lv_loc.Show();
                listView1.Hide();
            }
            
            else
            {
                this.Hide();
                HoiYeuCau fom2 = new HoiYeuCau();
                fom2.Show();
               
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xacnhanhvc xacnhanhvc = new xacnhanhvc();
            xacnhanhvc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fom2 = new Form1();
            fom2.Show();
            this.Hide();
        }
    }
}
