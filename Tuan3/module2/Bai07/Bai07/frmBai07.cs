using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class frmBai07 : Form
    {
        public frmBai07()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picOn_MouseHover(object sender, EventArgs e)
        {
            txtHienThi.Text= txtName.Text + ": Turn off the linght, please!!";
        }

        private void picOn_MouseClick(object sender, MouseEventArgs e)
        {
            picOn.Visible = false;
            picOff.Visible = true;
            
        }

        private void picOff_MouseClick(object sender, MouseEventArgs e)
        {
            picOn.Visible = true;
            picOff.Visible = false;

        }
    }
}
