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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar>'A'&&e.KeyChar>'Z'|| e.KeyChar > 'a' && e.KeyChar > 'z')
            {
                e.Handled = true;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double bKinh,chuVi;
            if (txtBanKinh.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập bán kính");

            }
            else
            {
                bKinh = Convert.ToDouble(txtBanKinh.Text);
                if (bKinh<=0)
                {
                    MessageBox.Show("bán kính >0");
                    txtBanKinh.Focus();
                }
                else {
                    chuVi = 2 * Math.PI * bKinh;
                    txtChuVi.Text = "" + chuVi;
                }
            }
        }
    }
}
