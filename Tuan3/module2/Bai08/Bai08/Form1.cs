using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // pnlButton.Controls.Clear();
                Button btnRuntime = new Button();
                btnRuntime.BackColor = Color.Red;
                btnRuntime.Location = new System.Drawing.Point(pnlButton.Width / 2 - btnRuntime.Width / 2,
                     pnlButton.Controls.Count * btnRuntime.Height);
                btnRuntime.Text = "Element " + pnlButton.Controls.Count;
                btnRuntime.Tag = pnlButton.Controls.Count;
                btnRuntime.Click += btnRuntime_click;
                pnlButton.Controls.Add(btnRuntime);

        }
        private void btnRuntime_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblHienThi.Text = "Status: " + btn.Text + " was clicked";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try {
                pnlButton.Controls.RemoveAt(pnlButton.Controls.Count - 1);
            }
            catch
            {
                
            }
            
        }
    }
}
