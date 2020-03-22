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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was click.");
        }

        private void Bai02_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi. wellcom to C# programing!");
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("form was click");
        }
    }
}
