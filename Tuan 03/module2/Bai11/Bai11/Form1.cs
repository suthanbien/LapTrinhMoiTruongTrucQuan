using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            pnlPic.Controls.Clear();
            OpenFileDialog fileOpenDlg = new OpenFileDialog();
            fileOpenDlg.Filter = "(*.jpeg)|*.jpeg|(*.jpg)|*.jpg";
            if (fileOpenDlg.ShowDialog() == DialogResult.OK)
            {

                PictureBox image = new PictureBox();
                var size = new FileInfo(fileOpenDlg.FileName).Length;
                DateTime dayAc = new FileInfo(fileOpenDlg.FileName).LastAccessTime;
                DateTime daylas = new FileInfo(fileOpenDlg.FileName).LastWriteTime;
                image.Image= Image.FromFile(fileOpenDlg.FileName);
                image.SizeMode = PictureBoxSizeMode.AutoSize;
                lblFileside.Text ="File Size: "+size+" byte";
                lblDaylass.Text = "Day lass modifile: " + daylas;
                lblDayAccest.Text = "Day last Access: " + dayAc;
                pnlPic.Controls.Add(image);
                
               



            }

        }
    }
}
