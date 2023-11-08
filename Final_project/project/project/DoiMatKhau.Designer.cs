namespace project
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.panel2 = new System.Windows.Forms.GroupBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.GroupBox();
            this.btn_ThayDoi = new System.Windows.Forms.Button();
            this.txt_NhapLai = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Ok);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Ma);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 191);
            this.panel2.TabIndex = 11;
            this.panel2.TabStop = false;
            this.panel2.Visible = false;
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(208, 123);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(120, 39);
            this.btn_Ok.TabIndex = 13;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(188, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập mã xác nhận";
            // 
            // txt_Ma
            // 
            this.txt_Ma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.Location = new System.Drawing.Point(155, 79);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(230, 38);
            this.txt_Ma.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_Mail);
            this.panel1.Controls.Add(this.txt_TenTK);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 229);
            this.panel1.TabIndex = 12;
            this.panel1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_ThayDoi);
            this.panel3.Controls.Add(this.txt_NhapLai);
            this.panel3.Controls.Add(this.txt_MK);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(19, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 253);
            this.panel3.TabIndex = 13;
            this.panel3.TabStop = false;
            this.panel3.Visible = false;
            // 
            // btn_ThayDoi
            // 
            this.btn_ThayDoi.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThayDoi.Location = new System.Drawing.Point(189, 163);
            this.btn_ThayDoi.Name = "btn_ThayDoi";
            this.btn_ThayDoi.Size = new System.Drawing.Size(179, 39);
            this.btn_ThayDoi.TabIndex = 13;
            this.btn_ThayDoi.Text = "Đổi mật khẩu";
            this.btn_ThayDoi.UseVisualStyleBackColor = false;
            this.btn_ThayDoi.Click += new System.EventHandler(this.btn_ThayDoi_Click_1);
            // 
            // txt_NhapLai
            // 
            this.txt_NhapLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_NhapLai.Location = new System.Drawing.Point(196, 76);
            this.txt_NhapLai.Name = "txt_NhapLai";
            this.txt_NhapLai.PasswordChar = '*';
            this.txt_NhapLai.Size = new System.Drawing.Size(286, 29);
            this.txt_NhapLai.TabIndex = 11;
            // 
            // txt_MK
            // 
            this.txt_MK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_MK.Location = new System.Drawing.Point(196, 30);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(286, 29);
            this.txt_MK.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(59, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Lấy mã xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_Mail
            // 
            this.txt_Mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Mail.Location = new System.Drawing.Point(188, 83);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(286, 29);
            this.txt_Mail.TabIndex = 11;
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_TenTK.Location = new System.Drawing.Point(188, 37);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(286, 29);
            this.txt_TenTK.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(34, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Email đăng ký:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(39, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tên tài khoản:";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 322);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel2;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.GroupBox panel3;
        private System.Windows.Forms.Button btn_ThayDoi;
        private System.Windows.Forms.TextBox txt_NhapLai;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}