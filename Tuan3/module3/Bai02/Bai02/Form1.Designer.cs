namespace Bai02
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chiều dài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập chiều rộng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Diện tích Hình chữ nhật là:";
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(193, 43);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(100, 22);
            this.txtDai.TabIndex = 1;
            this.txtDai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDai.TextChanged += new System.EventHandler(this.txtDai_TextChanged);
            this.txtDai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDai_KeyPress);
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(193, 89);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(100, 22);
            this.txtRong.TabIndex = 2;
            this.txtRong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRong_KeyPress);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(233, 171);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(100, 22);
            this.txtDienTich.TabIndex = 3;
            this.txtDienTich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(31, 225);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 37);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(215, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 274);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

