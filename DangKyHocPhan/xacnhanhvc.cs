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
    public partial class xacnhanhvc : Form
    {
        public xacnhanhvc()
        {
            InitializeComponent();
        }

        private void butquay_Click(object sender, EventArgs e)
        {
            hvc form1 = new hvc();
            form1.Show();
            this.Hide();
        }

        private void buttiep_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
