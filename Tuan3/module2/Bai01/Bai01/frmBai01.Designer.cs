namespace Bai01
{
    partial class frmBai01
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
            this.txtNhapPass = new System.Windows.Forms.TextBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hiển Thị:";
            // 
            // txtNhapPass
            // 
            this.txtNhapPass.Location = new System.Drawing.Point(155, 20);
            this.txtNhapPass.Name = "txtNhapPass";
            this.txtNhapPass.PasswordChar = '*';
            this.txtNhapPass.Size = new System.Drawing.Size(175, 22);
            this.txtNhapPass.TabIndex = 1;
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(154, 72);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.ReadOnly = true;
            this.txtHienThi.Size = new System.Drawing.Size(160, 22);
            this.txtHienThi.TabIndex = 2;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(28, 130);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 29);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(135, 130);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(85, 29);
            this.btnTiep.TabIndex = 3;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(270, 130);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 29);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmBai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 170);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.txtNhapPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai01";
            this.Text = "Xử dụng lable & Textbox";
            this.Load += new System.EventHandler(this.frmBai01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapPass;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnDong;
    }
}

