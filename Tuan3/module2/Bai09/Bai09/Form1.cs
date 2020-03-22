using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpenDlg = new OpenFileDialog();
            fileOpenDlg.Filter = "(*.txt)|*.txt|(*.txt)|*.txt";
            if (fileOpenDlg.ShowDialog() == DialogResult.OK)
            {
                
                txtHienThi.LoadFile(fileOpenDlg.FileName, RichTextBoxStreamType.PlainText) ;

            }

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (txtHienThi.SelectedText != "")
                {
                    txtHienThi.Font = fontDialog1.Font;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (txtHienThi.SelectedText != "")
                {
                    txtHienThi.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveMyFile();
        }
        public void SaveMyFile()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                txtHienThi.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
