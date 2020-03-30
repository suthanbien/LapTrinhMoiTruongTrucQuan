namespace Bai03
{
    partial class frmBai03
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
            this.lblHienThi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoVaTen = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.ForeColor = System.Drawing.Color.Red;
            this.lblHienThi.Location = new System.Drawing.Point(12, 9);
            this.lblHienThi.MinimumSize = new System.Drawing.Size(500, 50);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(500, 50);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHienThi.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Lót:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên: ";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(156, 88);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(304, 22);
            this.txtHoLot.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTen.Location = new System.Drawing.Point(159, 141);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(301, 22);
            this.txtTen.TabIndex = 2;
            // 
            // btnHoLot
            // 
            this.btnHoLot.Location = new System.Drawing.Point(34, 194);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(106, 44);
            this.btnHoLot.TabIndex = 3;
            this.btnHoLot.Text = "Họ Lót";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(205, 194);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(115, 44);
            this.btnTen.TabIndex = 3;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoVaTen
            // 
            this.btnHoVaTen.Location = new System.Drawing.Point(371, 194);
            this.btnHoVaTen.Name = "btnHoVaTen";
            this.btnHoVaTen.Size = new System.Drawing.Size(127, 44);
            this.btnHoVaTen.TabIndex = 3;
            this.btnHoVaTen.Text = "Họ Và Tên";
            this.btnHoVaTen.UseVisualStyleBackColor = true;
            this.btnHoVaTen.Click += new System.EventHandler(this.btnHoVaTen_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(179, 270);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(178, 47);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng chương trình";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmBai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 329);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHoVaTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHienThi);
            this.Name = "frmBai03";
            this.Text = "Bài Tập Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoVaTen;
        private System.Windows.Forms.Button btnDong;
    }
}

