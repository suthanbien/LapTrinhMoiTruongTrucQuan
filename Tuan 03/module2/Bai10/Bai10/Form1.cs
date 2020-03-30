using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
  
          System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCD_oiW2_g-BlDVHpUXl2V0w");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
 
    }
}
