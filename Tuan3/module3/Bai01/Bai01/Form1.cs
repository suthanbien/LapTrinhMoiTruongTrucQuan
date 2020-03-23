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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenHang.Focus();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int soluong;
            decimal donGia, thanhTien;
            if (txtSoLuong.Text=="")
            {
                MessageBox.Show("Chưa Nhập số lượng");
                txtSoLuong.Focus();
            }else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Chưa Nhập Đơn giá");
                txtDonGia.Focus();
            }
            else
            {
                soluong = Convert.ToInt32(txtSoLuong.Text);
                donGia = Convert.ToInt32(txtDonGia.Text);
                if (soluong <= 0)
                {
                    MessageBox.Show("Số lượng > 0");
                    txtSoLuong.SelectAll();
                    txtSoLuong.Focus();
                }else if (donGia <= 0)
                {
                    MessageBox.Show("đơn giá > 0");
                    txtDonGia.Focus();
                    txtDonGia.SelectAll();
                }   else
                {
                    thanhTien = soluong * donGia;
                    txtThanhTien.Text = "" + thanhTien;
                }
            }
            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            txtTenHang.Text = "";
            txtTenHang.Focus();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
            }
        }
    }
}
