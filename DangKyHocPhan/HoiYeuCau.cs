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
    public partial class HoiYeuCau : Form
    {
        public HoiYeuCau()
        {
            InitializeComponent();
        }

        private void HoiYeuCau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hvc fom2 = new hvc();
            fom2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fom2 = new Form2();
            fom2.Show();
            hvc fom = new hvc();
            fom.Hide();
            this.Hide();

        }

    
    }
}
