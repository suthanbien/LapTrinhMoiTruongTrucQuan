namespace Bai11
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.grbTitle = new System.Windows.Forms.GroupBox();
            this.pnlPic = new System.Windows.Forms.Panel();
            this.lblFileside = new System.Windows.Forms.Label();
            this.lblDaylass = new System.Windows.Forms.Label();
            this.lblDayAccest = new System.Windows.Forms.Label();
            this.grbTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click button to open a pictrure file";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(298, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(140, 36);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Browse...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // grbTitle
            // 
            this.grbTitle.Controls.Add(this.lblDayAccest);
            this.grbTitle.Controls.Add(this.lblDaylass);
            this.grbTitle.Controls.Add(this.lblFileside);
            this.grbTitle.Location = new System.Drawing.Point(15, 116);
            this.grbTitle.Name = "grbTitle";
            this.grbTitle.Size = new System.Drawing.Size(423, 182);
            this.grbTitle.TabIndex = 2;
            this.grbTitle.TabStop = false;
            this.grbTitle.Text = "File Static";
            // 
            // pnlPic
            // 
            this.pnlPic.AutoScroll = true;
            this.pnlPic.Location = new System.Drawing.Point(13, 314);
            this.pnlPic.Name = "pnlPic";
            this.pnlPic.Size = new System.Drawing.Size(425, 250);
            this.pnlPic.TabIndex = 3;
            // 
            // lblFileside
            // 
            this.lblFileside.AutoSize = true;
            this.lblFileside.Location = new System.Drawing.Point(16, 29);
            this.lblFileside.Name = "lblFileside";
            this.lblFileside.Size = new System.Drawing.Size(0, 17);
            this.lblFileside.TabIndex = 0;
            // 
            // lblDaylass
            // 
            this.lblDaylass.AutoSize = true;
            this.lblDaylass.Location = new System.Drawing.Point(19, 81);
            this.lblDaylass.Name = "lblDaylass";
            this.lblDaylass.Size = new System.Drawing.Size(0, 17);
            this.lblDaylass.TabIndex = 1;
            // 
            // lblDayAccest
            // 
            this.lblDayAccest.AutoSize = true;
            this.lblDayAccest.Location = new System.Drawing.Point(19, 126);
            this.lblDayAccest.Name = "lblDayAccest";
            this.lblDayAccest.Size = new System.Drawing.Size(0, 17);
            this.lblDayAccest.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 582);
            this.Controls.Add(this.pnlPic);
            this.Controls.Add(this.grbTitle);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbTitle.ResumeLayout(false);
            this.grbTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox grbTitle;
        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.Label lblFileside;
        private System.Windows.Forms.Label lblDayAccest;
        private System.Windows.Forms.Label lblDaylass;
    }
}

