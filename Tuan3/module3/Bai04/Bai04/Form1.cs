using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radBat_CheckedChanged(object sender, EventArgs e)
        {
            if (radBat1.Checked)
            {
                lblDeBai.Text = "Giải Phương Trình Bật 1";
                txtSoC.Visible = false;
                lblNhapC.Visible = false;

            }else
            {
                lblDeBai.Text = "Giải Phương Trình Bật 2";
                txtSoC.Visible = true;
                lblNhapC.Visible = true;
            }
        }

    

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDeBai.Text = "Giải Phương Trình Bật 1";
            txtSoC.Visible = false;
            lblNhapC.Visible = false;
            txtSoA.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtSoC.Text = "";
            rtxtKetQua.Clear();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (radBat1.Checked)
            {
                float soA, soB;
                if (txtSoA.Text.Equals("") || txtSoB.Text.Equals(""))
                {
                    MessageBox.Show("vui lòng nhập a,b");
                }
                else
                {
                    soA = Convert.ToInt32(txtSoA.Text);
                    soB = Convert.ToInt32(txtSoB.Text);
                    if (soA == 0)
                    {
                        if (soB == 0)
                            rtxtKetQua.Text = ("Phuong trinh co vo so nghiem.");
                        else
                            rtxtKetQua.Text = ("Phuong trinh vo nghiem.");
                    }
                    else
                        rtxtKetQua.Text = ("X = " + -soB / soA);
                }

            }
            else 
            {
                double a, b, c, d;
                if (txtSoA.Text.Equals("") || txtSoB.Text.Equals("") || txtSoC.Text.Equals(""))
                {
                    MessageBox.Show("vui lòng nhập a,b,c");
                }
                else
                {
                    a = Convert.ToInt32(txtSoA.Text);
                    b = Convert.ToInt32(txtSoB.Text);
                    c = Convert.ToInt32(txtSoC.Text);

                    if (a == 0)
                    {
                        if (b == 0)
                        {
                            if (c == 0)
                                rtxtKetQua.Text=("Phuong trinh co vo so nghiem.");
                            else
                                rtxtKetQua.Text=("Phuong trinh vo nghiem.");
                        }
                        else
                            rtxtKetQua.Text=("X1 = X2 = " + -c / b);
                    }
                    else
                    {
                        d = Math.Pow(b, 2) - 4 * a * c;
                        if (d < 0)
                            rtxtKetQua.Text=("Phuong trinh vo nghiem..");
                        else if (d == 0)
                            rtxtKetQua.Text=("X1 = X2 =  " + -b / (2 * a));
                        else
                            rtxtKetQua.Text=("X1 = " + (-b + Math.Sqrt(d)) / (2 * a) + " ,X2 = " + (-b - Math.Sqrt(d)) / (2 * a));
                    }
                }
                   
            }
        }

        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar>'A'&& e.KeyChar > 'Z'|| e.KeyChar > 'a'&& e.KeyChar > 'z')
            {
                e.Handled = true;
            }
        }
    }
}
