namespace Bai06
{
    partial class frmBai06
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessager = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCoLor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblMessager = new System.Windows.Forms.Label();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grbCoLor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMessager);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Name &  Messager";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(503, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtMessager
            // 
            this.txtMessager.Location = new System.Drawing.Point(155, 99);
            this.txtMessager.Name = "txtMessager";
            this.txtMessager.Size = new System.Drawing.Size(503, 22);
            this.txtMessager.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Messager:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grbCoLor
            // 
            this.grbCoLor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbCoLor.Controls.Add(this.radBlack);
            this.grbCoLor.Controls.Add(this.radBlue);
            this.grbCoLor.Controls.Add(this.radGreen);
            this.grbCoLor.Controls.Add(this.radRed);
            this.grbCoLor.Location = new System.Drawing.Point(12, 202);
            this.grbCoLor.Name = "grbCoLor";
            this.grbCoLor.Size = new System.Drawing.Size(201, 221);
            this.grbCoLor.TabIndex = 3;
            this.grbCoLor.TabStop = false;
            this.grbCoLor.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(49, 173);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(63, 21);
            this.radBlack.TabIndex = 0;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(49, 119);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(57, 21);
            this.radBlue.TabIndex = 0;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(49, 80);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(69, 21);
            this.radGreen.TabIndex = 0;
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
            this.radRed.Location = new System.Drawing.Point(49, 40);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(55, 21);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Location = new System.Drawing.Point(301, 202);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(137, 21);
            this.chkVisible.TabIndex = 0;
            this.chkVisible.Text = "Messager Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Location = new System.Drawing.Point(530, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 221);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(49, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 60);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(49, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 49);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(49, 21);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(106, 53);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.button1_Click);
            this.btnDisplay.Enter += new System.EventHandler(this.btnDisplay_Enter);
            // 
            // lblMessager
            // 
            this.lblMessager.AutoSize = true;
            this.lblMessager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMessager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessager.Location = new System.Drawing.Point(8, 489);
            this.lblMessager.MinimumSize = new System.Drawing.Size(740, 50);
            this.lblMessager.Name = "lblMessager";
            this.lblMessager.Size = new System.Drawing.Size(740, 50);
            this.lblMessager.TabIndex = 4;
            this.lblMessager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSmall
            // 
            this.picSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSmall.Image = global::Bai06.Properties.Resources.received_324620541689990;
            this.picSmall.Location = new System.Drawing.Point(312, 230);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(126, 63);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmall.TabIndex = 5;
            this.picSmall.TabStop = false;
            this.picSmall.UseWaitCursor = true;
            this.picSmall.Click += new System.EventHandler(this.picSmall_Click);
            this.picSmall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picSmall_MouseClick);
            // 
            // picBig
            // 
            this.picBig.Image = global::Bai06.Properties.Resources.received_324620541689990;
            this.picBig.Location = new System.Drawing.Point(242, 299);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(266, 167);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBig.TabIndex = 6;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            this.picBig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBig_MouseClick);
            // 
            // frmBai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 549);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblMessager);
            this.Controls.Add(this.grbCoLor);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBai06";
            this.Text = "Messager Formater";
            this.Load += new System.EventHandler(this.frmBai06_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCoLor.ResumeLayout(false);
            this.grbCoLor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbCoLor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblMessager;
        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.PictureBox picBig;
    }
}

