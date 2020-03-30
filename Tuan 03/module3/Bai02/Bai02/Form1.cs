using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDai.Focus();
        }

        private void txtDai_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar>'A'&& e.KeyChar > 'Z' || e.KeyChar >'a' && e.KeyChar > 'z')
            {
                e.Handled = true;
            }
        }

        private void txtRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 'A' && e.KeyChar > 'Z' || e.KeyChar > 'a' && e.KeyChar > 'z')
            {
                e.Handled = true;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int cDai, cRong;

            if (txtDai.Text.Equals("")||txtRong.Text.Equals(""))
            {
                MessageBox.Show("chiều dài và rộng không được để trống!");
            }else 
            {
                cDai = Convert.ToInt32(txtDai.Text);
                cRong = Convert.ToInt32(txtRong.Text);
                if (cDai<=0||cRong<=0)
                {
                    MessageBox.Show("chiều dài và rộng phải lớn hơn 0!");
                }
                else
                {
                    txtDienTich.Text =""+ cRong * cDai;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
