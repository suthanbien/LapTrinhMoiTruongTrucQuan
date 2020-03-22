using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class frmBai01 : Form
    {
        public frmBai01()
        {
            InitializeComponent();
        }

        private void frmBai01_Load(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtNhapPass.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "";
            txtNhapPass.Text = "";
            txtNhapPass.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
