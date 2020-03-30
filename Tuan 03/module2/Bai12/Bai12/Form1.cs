using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            lbChon.Items.Clear();
            for(int i = 0; i < cklisChon.Items.Count; i++)
            {
                if (cklisChon.GetItemChecked(i))
                {
                    lbChon.Items.Add(cklisChon.Items[i].ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 10; i++)
            {
                cklisChon.Items.Add("vi tri:"+i, false);
            }
        }
    }
}
