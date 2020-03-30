using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class frmBai03 : Form
    {
        public frmBai03()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtTen.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtHoLot.Text + " " + txtTen.Text;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
