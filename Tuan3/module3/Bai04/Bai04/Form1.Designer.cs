namespace Bai04
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
            this.lblDeBai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBat2 = new System.Windows.Forms.RadioButton();
            this.radBat1 = new System.Windows.Forms.RadioButton();
            this.lblNhapC = new System.Windows.Forms.Label();
            this.rtxtKetQua = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeBai
            // 
            this.lblDeBai.AutoSize = true;
            this.lblDeBai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDeBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeBai.ForeColor = System.Drawing.Color.Red;
            this.lblDeBai.Location = new System.Drawing.Point(-6, -4);
            this.lblDeBai.MinimumSize = new System.Drawing.Size(600, 50);
            this.lblDeBai.Name = "lblDeBai";
            this.lblDeBai.Size = new System.Drawing.Size(600, 50);
            this.lblDeBai.TabIndex = 0;
            this.lblDeBai.Text = "Giải Phương Trình Bật 1";
            this.lblDeBai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập b";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(189, 36);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 22);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo_KeyPress);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(189, 83);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 22);
            this.txtSoB.TabIndex = 2;
            this.txtSoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo_KeyPress);
            // 
            // txtSoC
            // 
            this.txtSoC.Location = new System.Drawing.Point(189, 130);
            this.txtSoC.Name = "txtSoC";
            this.txtSoC.Size = new System.Drawing.Size(100, 22);
            this.txtSoC.TabIndex = 3;
            this.txtSoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoC.Visible = false;
            this.txtSoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBat2);
            this.groupBox1.Controls.Add(this.radBat1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNhapC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoC);
            this.groupBox1.Controls.Add(this.txtSoB);
            this.groupBox1.Controls.Add(this.txtSoA);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radBat2
            // 
            this.radBat2.AutoSize = true;
            this.radBat2.Location = new System.Drawing.Point(371, 88);
            this.radBat2.Name = "radBat2";
            this.radBat2.Size = new System.Drawing.Size(181, 21);
            this.radBat2.TabIndex = 7;
            this.radBat2.Text = "Giải Phương Trình Bật 2";
            this.radBat2.UseVisualStyleBackColor = true;
            this.radBat2.CheckedChanged += new System.EventHandler(this.radBat_CheckedChanged);
            // 
            // radBat1
            // 
            this.radBat1.AutoSize = true;
            this.radBat1.Checked = true;
            this.radBat1.Location = new System.Drawing.Point(371, 34);
            this.radBat1.Name = "radBat1";
            this.radBat1.Size = new System.Drawing.Size(181, 21);
            this.radBat1.TabIndex = 4;
            this.radBat1.TabStop = true;
            this.radBat1.Text = "Giải Phương Trình Bật 1";
            this.radBat1.UseVisualStyleBackColor = true;
            this.radBat1.CheckedChanged += new System.EventHandler(this.radBat_CheckedChanged);
            // 
            // lblNhapC
            // 
            this.lblNhapC.AutoSize = true;
            this.lblNhapC.Location = new System.Drawing.Point(69, 135);
            this.lblNhapC.Name = "lblNhapC";
            this.lblNhapC.Size = new System.Drawing.Size(53, 17);
            this.lblNhapC.TabIndex = 0;
            this.lblNhapC.Text = "Nhập c";
            this.lblNhapC.Visible = false;
            // 
            // rtxtKetQua
            // 
            this.rtxtKetQua.Location = new System.Drawing.Point(264, 289);
            this.rtxtKetQua.Name = "rtxtKetQua";
            this.rtxtKetQua.ReadOnly = true;
            this.rtxtKetQua.Size = new System.Drawing.Size(193, 124);
            this.rtxtKetQua.TabIndex = 3;
            this.rtxtKetQua.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết Quả";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(56, 469);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(91, 39);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(241, 469);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(422, 469);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 39);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.rtxtKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDeBai);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeBai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBat2;
        private System.Windows.Forms.RadioButton radBat1;
        private System.Windows.Forms.Label lblNhapC;
        private System.Windows.Forms.RichTextBox rtxtKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDong;
    }
}

