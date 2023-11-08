namespace BTH3
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            this.btn_DangNhap = new ReaLTaiizor.Controls.Button();
            this.txt_matkhau = new CustomControls.RJControls.RJTextBox();
            this.txt_tendangnhap = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel1.Location = new System.Drawing.Point(12, 117);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(125, 21);
            this.skyLabel1.TabIndex = 2;
            this.skyLabel1.Text = "Tên đăng nhập:";
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel2.Location = new System.Drawing.Point(36, 158);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(83, 21);
            this.skyLabel2.TabIndex = 3;
            this.skyLabel2.Text = "Mật khẩu:";
            // 
            // skyLabel3
            // 
            this.skyLabel3.AutoSize = true;
            this.skyLabel3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel3.Location = new System.Drawing.Point(124, 36);
            this.skyLabel3.Name = "skyLabel3";
            this.skyLabel3.Size = new System.Drawing.Size(133, 31);
            this.skyLabel3.TabIndex = 4;
            this.skyLabel3.Text = "Đăng nhập";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_DangNhap.Image = null;
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangNhap.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_DangNhap.Location = new System.Drawing.Point(130, 210);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_DangNhap.Size = new System.Drawing.Size(108, 35);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.SystemColors.Window;
            this.txt_matkhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_matkhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_matkhau.BorderRadius = 15;
            this.txt_matkhau.BorderSize = 2;
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_matkhau.Location = new System.Drawing.Point(141, 146);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matkhau.Multiline = false;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_matkhau.PasswordChar = true;
            this.txt_matkhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_matkhau.PlaceholderText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(221, 36);
            this.txt_matkhau.TabIndex = 7;
            this.txt_matkhau.Texts = "matkhau";
            this.txt_matkhau.UnderlinedStyle = false;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tendangnhap.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_tendangnhap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tendangnhap.BorderRadius = 15;
            this.txt_tendangnhap.BorderSize = 2;
            this.txt_tendangnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tendangnhap.Location = new System.Drawing.Point(141, 102);
            this.txt_tendangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendangnhap.Multiline = false;
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tendangnhap.PasswordChar = false;
            this.txt_tendangnhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tendangnhap.PlaceholderText = "";
            this.txt_tendangnhap.Size = new System.Drawing.Size(221, 36);
            this.txt_tendangnhap.TabIndex = 0;
            this.txt_tendangnhap.Texts = "user";
            this.txt_tendangnhap.UnderlinedStyle = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 272);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.skyLabel3);
            this.Controls.Add(this.skyLabel2);
            this.Controls.Add(this.skyLabel1);
            this.Controls.Add(this.txt_tendangnhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txt_tendangnhap;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private ReaLTaiizor.Controls.Button btn_DangNhap;
        private CustomControls.RJControls.RJTextBox txt_matkhau;
    }
}