namespace Bai12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChon = new System.Windows.Forms.ListBox();
            this.cklisChon = new System.Windows.Forms.CheckedListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Cript:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Cript:";
            // 
            // lbChon
            // 
            this.lbChon.FormattingEnabled = true;
            this.lbChon.ItemHeight = 16;
            this.lbChon.Location = new System.Drawing.Point(266, 85);
            this.lbChon.Name = "lbChon";
            this.lbChon.Size = new System.Drawing.Size(186, 196);
            this.lbChon.TabIndex = 1;
            // 
            // cklisChon
            // 
            this.cklisChon.FormattingEnabled = true;
            this.cklisChon.Location = new System.Drawing.Point(34, 85);
            this.cklisChon.Name = "cklisChon";
            this.cklisChon.Size = new System.Drawing.Size(168, 327);
            this.cklisChon.TabIndex = 2;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(301, 356);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(121, 56);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 456);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cklisChon);
            this.Controls.Add(this.lbChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbChon;
        private System.Windows.Forms.CheckedListBox cklisChon;
        private System.Windows.Forms.Button btnDone;
    }
}

