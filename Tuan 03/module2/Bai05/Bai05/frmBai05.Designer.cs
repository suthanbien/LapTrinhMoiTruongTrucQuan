namespace Bai05
{
    partial class frmBai05
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
            this.lblNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.chkDam = new System.Windows.Forms.CheckBox();
            this.chkNgieng = new System.Windows.Forms.CheckBox();
            this.grbCoLor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblHienThiND = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grbCoLor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblNhap.ForeColor = System.Drawing.Color.Lime;
            this.lblNhap.Location = new System.Drawing.Point(58, 44);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(46, 17);
            this.lblNhap.TabIndex = 0;
            this.lblNhap.Text = "Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(58, 348);
            this.label2.MinimumSize = new System.Drawing.Size(100, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hiển Thị";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(142, 39);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(297, 22);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.chkGachChan);
            this.groupBox1.Controls.Add(this.chkDam);
            this.groupBox1.Controls.Add(this.chkNgieng);
            this.groupBox1.Location = new System.Drawing.Point(299, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font";
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.ForeColor = System.Drawing.Color.Blue;
            this.chkGachChan.Location = new System.Drawing.Point(33, 137);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(101, 21);
            this.chkGachChan.TabIndex = 0;
            this.chkGachChan.Text = "Gạch Chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            // 
            // chkDam
            // 
            this.chkDam.AutoSize = true;
            this.chkDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDam.ForeColor = System.Drawing.Color.Blue;
            this.chkDam.Location = new System.Drawing.Point(33, 39);
            this.chkDam.Name = "chkDam";
            this.chkDam.Size = new System.Drawing.Size(99, 21);
            this.chkDam.TabIndex = 0;
            this.chkDam.Text = "Đậm Bold";
            this.chkDam.UseVisualStyleBackColor = true;
            // 
            // chkNgieng
            // 
            this.chkNgieng.AutoSize = true;
            this.chkNgieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNgieng.ForeColor = System.Drawing.Color.Blue;
            this.chkNgieng.Location = new System.Drawing.Point(33, 88);
            this.chkNgieng.Name = "chkNgieng";
            this.chkNgieng.Size = new System.Drawing.Size(107, 21);
            this.chkNgieng.TabIndex = 0;
            this.chkNgieng.Text = "Ngiêng Italic";
            this.chkNgieng.UseVisualStyleBackColor = true;
            // 
            // grbCoLor
            // 
            this.grbCoLor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbCoLor.Controls.Add(this.radBlack);
            this.grbCoLor.Controls.Add(this.radBlue);
            this.grbCoLor.Controls.Add(this.radGreen);
            this.grbCoLor.Controls.Add(this.radRed);
            this.grbCoLor.Location = new System.Drawing.Point(38, 86);
            this.grbCoLor.Name = "grbCoLor";
            this.grbCoLor.Size = new System.Drawing.Size(201, 187);
            this.grbCoLor.TabIndex = 2;
            this.grbCoLor.TabStop = false;
            this.grbCoLor.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(23, 146);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(63, 21);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(23, 106);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(57, 21);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(24, 65);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(69, 21);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Checked = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(23, 38);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(55, 21);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(355, 347);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(121, 59);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblHienThiND
            // 
            this.lblHienThiND.AutoSize = true;
            this.lblHienThiND.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHienThiND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiND.ForeColor = System.Drawing.Color.Black;
            this.lblHienThiND.Location = new System.Drawing.Point(173, 331);
            this.lblHienThiND.MinimumSize = new System.Drawing.Size(150, 50);
            this.lblHienThiND.Name = "lblHienThiND";
            this.lblHienThiND.Size = new System.Drawing.Size(150, 50);
            this.lblHienThiND.TabIndex = 0;
            this.lblHienThiND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 418);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grbCoLor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lblHienThiND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNhap);
            this.Name = "frmBai05";
            this.Text = "Định dạng Form(fomater)";
            this.Load += new System.EventHandler(this.frmBai05_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCoLor.ResumeLayout(false);
            this.grbCoLor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.CheckBox chkDam;
        private System.Windows.Forms.CheckBox chkNgieng;
        private System.Windows.Forms.GroupBox grbCoLor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblHienThiND;
    }
}

