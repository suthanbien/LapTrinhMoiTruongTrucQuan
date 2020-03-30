namespace Bai07
{
    partial class frmBai07
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.picOff = new System.Windows.Forms.PictureBox();
            this.picOn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(180, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 36);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(399, 439);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(131, 56);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Exit";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtHienThi
            // 
            this.txtHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienThi.Location = new System.Drawing.Point(87, 366);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.ReadOnly = true;
            this.txtHienThi.Size = new System.Drawing.Size(383, 36);
            this.txtHienThi.TabIndex = 1;
            this.txtHienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(29, 441);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(348, 39);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Designed by:______";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picOff
            // 
            this.picOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOff.Image = global::Bai07.Properties.Resources.received_509420279536740;
            this.picOff.Location = new System.Drawing.Point(136, 98);
            this.picOff.Name = "picOff";
            this.picOff.Size = new System.Drawing.Size(274, 223);
            this.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOff.TabIndex = 2;
            this.picOff.TabStop = false;
            this.picOff.Visible = false;
            this.picOff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOff_MouseClick);
            // 
            // picOn
            // 
            this.picOn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOn.Image = global::Bai07.Properties.Resources.received_262176931124966;
            this.picOn.Location = new System.Drawing.Point(136, 98);
            this.picOn.Name = "picOn";
            this.picOn.Size = new System.Drawing.Size(274, 223);
            this.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOn.TabIndex = 2;
            this.picOn.TabStop = false;
            this.picOn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOn_MouseClick);
            this.picOn.MouseHover += new System.EventHandler(this.picOn_MouseHover);
            // 
            // frmBai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 507);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.picOff);
            this.Controls.Add(this.picOn);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(560, 554);
            this.Name = "frmBai07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light";
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picOn;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox picOff;
    }
}

