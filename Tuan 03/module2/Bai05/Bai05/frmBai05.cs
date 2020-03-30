using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class frmBai05 : Form
    {
        public frmBai05()
        {
            InitializeComponent();
        }

        public void checkColor()
        {
            if (radRed.Checked)
            {
                lblHienThiND.ForeColor = Color.Red;
            }else if (radBlue.Checked)
            {
                lblHienThiND.ForeColor = Color.Blue;
            }
            else if (radBlack.Checked)
            {
                lblHienThiND.ForeColor = Color.Black;
            }
            else if (radGreen.Checked)
            {
                lblHienThiND.ForeColor = Color.Green;
            }
        }
        public void checkFont()
        {
            if (chkDam.Checked)
            {
                lblHienThiND.Font = new Font(lblHienThiND.Font.Name, 
                    lblHienThiND.Font.Size, lblHienThiND.Font.Style ^ FontStyle.Bold);
            }
            else if (chkNgieng.Checked)
            {
                lblHienThiND.Font = new Font(lblHienThiND.Font.Name,
                    lblHienThiND.Font.Size, lblHienThiND.Font.Style ^ FontStyle.Italic);
            }
            else if (chkGachChan.Checked)
            {
                lblHienThiND.Font = new Font(lblHienThiND.Font.Name,
                    lblHienThiND.Font.Size, lblHienThiND.Font.Style ^ FontStyle.Underline);
            }
        }


        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            checkColor();
            checkFont();
        }

        private void frmBai05_Load(object sender, EventArgs e)
        {
            txtNhap.Focus();
            checkColor();
            checkFont();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            lblHienThiND.Text = txtNhap.Text;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
