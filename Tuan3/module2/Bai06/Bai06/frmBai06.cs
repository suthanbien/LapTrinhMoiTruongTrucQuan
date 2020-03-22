using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class frmBai06 : Form
    {
        public frmBai06()
        {
            InitializeComponent();
        }

        public void checkColor()
        {
            if (radRed.Checked)
            {
                lblMessager.ForeColor = Color.Red;
            }
            else if (radBlue.Checked)
            {
                lblMessager.ForeColor = Color.Blue;
            }
            else if (radBlack.Checked)
            {
                lblMessager .ForeColor = Color.Black;
            }
            else if (radGreen.Checked)
            {
                lblMessager.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessager.Text = txtName.Text + ": " + txtMessager.Text;

        }

        private void frmBai06_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            picSmall.Visible = false;
        }

        private void btnDisplay_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessager.Text = "";
            lblMessager.Text = "";
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            checkColor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessager.Visible = chkVisible.Checked;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            
        }

        private void picSmall_MouseClick(object sender, MouseEventArgs e)
        {
            
            picBig.Visible = true;
            picSmall.Visible = false;
        }

        private void picBig_MouseClick(object sender, MouseEventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }
    }
}
