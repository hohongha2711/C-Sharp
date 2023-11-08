namespace project
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
            this.btn_DangNhap = new ReaLTaiizor.Controls.Button();
            this.skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.lb_quenmatkhau = new ReaLTaiizor.Controls.DungeonLinkLabel();
            this.lb_taotk = new ReaLTaiizor.Controls.DungeonLinkLabel();
            this.quyen = new System.Windows.Forms.ComboBox();
            this.skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            this.txt_tentk = new CustomControls.RJControls.RJTextBox();
            this.txt_mk = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Image = null;
            this.btn_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangNhap.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_DangNhap.Location = new System.Drawing.Point(253, 273);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_DangNhap.Size = new System.Drawing.Size(136, 41);
            this.btn_DangNhap.TabIndex = 9;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // skyLabel3
            // 
            this.skyLabel3.AutoSize = true;
            this.skyLabel3.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.skyLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel3.Location = new System.Drawing.Point(237, 9);
            this.skyLabel3.Name = "skyLabel3";
            this.skyLabel3.Size = new System.Drawing.Size(163, 39);
            this.skyLabel3.TabIndex = 8;
            this.skyLabel3.Text = "Đăng nhập";
            this.skyLabel3.Click += new System.EventHandler(this.skyLabel3_Click);
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel2.Location = new System.Drawing.Point(164, 211);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(110, 27);
            this.skyLabel2.TabIndex = 7;
            this.skyLabel2.Text = "Mật khẩu:";
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel1.Location = new System.Drawing.Point(114, 149);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(160, 27);
            this.skyLabel1.TabIndex = 6;
            this.skyLabel1.Text = "Tên đăng nhập:";
            // 
            // lb_quenmatkhau
            // 
            this.lb_quenmatkhau.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.lb_quenmatkhau.AutoSize = true;
            this.lb_quenmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_quenmatkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quenmatkhau.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lb_quenmatkhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lb_quenmatkhau.Location = new System.Drawing.Point(360, 343);
            this.lb_quenmatkhau.Name = "lb_quenmatkhau";
            this.lb_quenmatkhau.Size = new System.Drawing.Size(117, 21);
            this.lb_quenmatkhau.TabIndex = 12;
            this.lb_quenmatkhau.TabStop = true;
            this.lb_quenmatkhau.Text = "Quên mật khẩu";
            this.lb_quenmatkhau.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lb_quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_quenmatkhau_LinkClicked);
            // 
            // lb_taotk
            // 
            this.lb_taotk.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.lb_taotk.AutoSize = true;
            this.lb_taotk.BackColor = System.Drawing.Color.Transparent;
            this.lb_taotk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taotk.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lb_taotk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lb_taotk.Location = new System.Drawing.Point(145, 343);
            this.lb_taotk.Name = "lb_taotk";
            this.lb_taotk.Size = new System.Drawing.Size(135, 21);
            this.lb_taotk.TabIndex = 13;
            this.lb_taotk.TabStop = true;
            this.lb_taotk.Text = "Tạo tài khoản mới";
            this.lb_taotk.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.lb_taotk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_taotk_LinkClicked);
            // 
            // quyen
            // 
            this.quyen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quyen.FormattingEnabled = true;
            this.quyen.Items.AddRange(new object[] {
            "Nhà tuyển dụng",
            "Ứng viên"});
            this.quyen.Location = new System.Drawing.Point(326, 87);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(187, 31);
            this.quyen.TabIndex = 16;
            this.quyen.Text = "Ứng viên";
            // 
            // skyLabel4
            // 
            this.skyLabel4.AutoSize = true;
            this.skyLabel4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel4.ForeColor = System.Drawing.Color.Black;
            this.skyLabel4.Location = new System.Drawing.Point(130, 90);
            this.skyLabel4.Name = "skyLabel4";
            this.skyLabel4.Size = new System.Drawing.Size(190, 23);
            this.skyLabel4.TabIndex = 17;
            this.skyLabel4.Text = "Đăng nhập với quyền:";
            // 
            // txt_tentk
            // 
            this.txt_tentk.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tentk.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_tentk.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tentk.BorderRadius = 15;
            this.txt_tentk.BorderSize = 2;
            this.txt_tentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tentk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tentk.Location = new System.Drawing.Point(281, 145);
            this.txt_tentk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tentk.Multiline = false;
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tentk.PasswordChar = false;
            this.txt_tentk.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tentk.PlaceholderText = "";
            this.txt_tentk.Size = new System.Drawing.Size(241, 39);
            this.txt_tentk.TabIndex = 21;
            this.txt_tentk.Texts = "";
            this.txt_tentk.UnderlinedStyle = false;
            // 
            // txt_mk
            // 
            this.txt_mk.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mk.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_mk.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_mk.BorderRadius = 15;
            this.txt_mk.BorderSize = 2;
            this.txt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mk.Location = new System.Drawing.Point(281, 199);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mk.Multiline = false;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_mk.PasswordChar = true;
            this.txt_mk.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_mk.PlaceholderText = "";
            this.txt_mk.Size = new System.Drawing.Size(241, 39);
            this.txt_mk.TabIndex = 20;
            this.txt_mk.Texts = "";
            this.txt_mk.UnderlinedStyle = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 381);
            this.Controls.Add(this.txt_tentk);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.skyLabel4);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.lb_taotk);
            this.Controls.Add(this.lb_quenmatkhau);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.skyLabel3);
            this.Controls.Add(this.skyLabel2);
            this.Controls.Add(this.skyLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.Button btn_DangNhap;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.DungeonLinkLabel lb_quenmatkhau;
        private ReaLTaiizor.Controls.DungeonLinkLabel lb_taotk;
        private System.Windows.Forms.ComboBox quyen;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private CustomControls.RJControls.RJTextBox txt_mk;
        private CustomControls.RJControls.RJTextBox txt_tentk;
    }
}

