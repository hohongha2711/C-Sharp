namespace project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.btn_all = new System.Windows.Forms.Button();
            this.khuvuc = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.bt_Chao = new ReaLTaiizor.Controls.LabelEdit();
            this.lb_tim = new ReaLTaiizor.Controls.LabelEdit();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_timkiem = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_next = new CustomControls.RJControls.RJButton();
            this.btn_pre = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btn_all);
            this.panel1.Controls.Add(this.khuvuc);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.labelEdit1);
            this.panel1.Controls.Add(this.bt_Chao);
            this.panel1.Controls.Add(this.lb_tim);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.hopePictureBox1);
            this.panel1.EdgeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1235, 217);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.Snow;
            this.btn_all.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.Location = new System.Drawing.Point(892, 155);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(149, 31);
            this.btn_all.TabIndex = 18;
            this.btn_all.Text = "Xem tất cả";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // khuvuc
            // 
            this.khuvuc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khuvuc.FormattingEnabled = true;
            this.khuvuc.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Hà Nội",
            "All"});
            this.khuvuc.Location = new System.Drawing.Point(597, 155);
            this.khuvuc.Name = "khuvuc";
            this.khuvuc.Size = new System.Drawing.Size(225, 31);
            this.khuvuc.TabIndex = 17;
            this.khuvuc.Text = "Khu vực";
            this.khuvuc.SelectedIndexChanged += new System.EventHandler(this.khuvuc_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(117, 90);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng xuất";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.labelEdit1.Location = new System.Drawing.Point(592, 97);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(474, 29);
            this.labelEdit1.TabIndex = 9;
            this.labelEdit1.Text = "(Tìm kiếm tên công việc, công ty, lĩnh vực...)";
            // 
            // bt_Chao
            // 
            this.bt_Chao.AllowDrop = true;
            this.bt_Chao.AutoEllipsis = true;
            this.bt_Chao.BackColor = System.Drawing.Color.Transparent;
            this.bt_Chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Chao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.bt_Chao.Location = new System.Drawing.Point(117, 9);
            this.bt_Chao.Name = "bt_Chao";
            this.bt_Chao.Size = new System.Drawing.Size(395, 74);
            this.bt_Chao.TabIndex = 8;
            this.bt_Chao.Text = "Xin chào, ";
            // 
            // lb_tim
            // 
            this.lb_tim.AutoSize = true;
            this.lb_tim.BackColor = System.Drawing.Color.Transparent;
            this.lb_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lb_tim.Location = new System.Drawing.Point(592, 19);
            this.lb_tim.Name = "lb_tim";
            this.lb_tim.Size = new System.Drawing.Size(113, 29);
            this.lb_tim.TabIndex = 7;
            this.lb_tim.Text = "Tìm kiếm";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Snow;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1123, 51);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 44);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BackColor = System.Drawing.Color.Transparent;
            this.txt_timkiem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_timkiem.ForeColor = System.Drawing.Color.DimGray;
            this.txt_timkiem.Image = null;
            this.txt_timkiem.Location = new System.Drawing.Point(597, 51);
            this.txt_timkiem.MaxLength = 32767;
            this.txt_timkiem.Multiline = false;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.ReadOnly = false;
            this.txt_timkiem.Size = new System.Drawing.Size(520, 43);
            this.txt_timkiem.TabIndex = 3;
            this.txt_timkiem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_timkiem.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.bigLabel1.ForeColor = System.Drawing.Color.Coral;
            this.bigLabel1.Location = new System.Drawing.Point(11, 164);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(135, 37);
            this.bigLabel1.TabIndex = 2;
            this.bigLabel1.Text = "bigLabel1";
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.Location = new System.Drawing.Point(8, 8);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(103, 102);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 1;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hopePictureBox1.Click += new System.EventHandler(this.hopePictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 235);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1230, 555);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_next.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_next.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_next.BorderRadius = 0;
            this.btn_next.BorderSize = 0;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(676, 796);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(98, 30);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Next";
            this.btn_next.TextColor = System.Drawing.Color.White;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_pre.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_pre.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_pre.BorderRadius = 0;
            this.btn_pre.BorderSize = 0;
            this.btn_pre.FlatAppearance.BorderSize = 0;
            this.btn_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pre.ForeColor = System.Drawing.Color.White;
            this.btn_pre.Location = new System.Drawing.Point(551, 796);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(98, 30);
            this.btn_pre.TabIndex = 3;
            this.btn_pre.Text = "Previous";
            this.btn_pre.TextColor = System.Drawing.Color.White;
            this.btn_pre.UseVisualStyleBackColor = false;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 838);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private CustomControls.RJControls.RJButton btn_pre;
        private CustomControls.RJControls.RJButton btn_next;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox txt_timkiem;
        private ReaLTaiizor.Controls.LabelEdit bt_Chao;
        private ReaLTaiizor.Controls.LabelEdit lb_tim;
        private System.Windows.Forms.Button btn_search;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox khuvuc;
        private System.Windows.Forms.Button btn_all;
    }
}