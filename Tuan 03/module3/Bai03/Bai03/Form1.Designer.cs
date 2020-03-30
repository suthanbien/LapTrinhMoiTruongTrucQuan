namespace Bai03
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
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Bán Kính";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(247, 94);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(100, 22);
            this.txtBanKinh.TabIndex = 0;
            this.txtBanKinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBanKinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanKinh_KeyPress);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(63, 284);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(117, 55);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chu Vi Hình Tròn Là:";
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(247, 204);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.Size = new System.Drawing.Size(100, 22);
            this.txtChuVi.TabIndex = 1;
            this.txtChuVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(247, 284);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 55);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 448);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Button btnDong;
    }
}

