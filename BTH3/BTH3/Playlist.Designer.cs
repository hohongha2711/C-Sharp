namespace BTH3
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_taopl = new ReaLTaiizor.Controls.Button();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.groupBox_themds = new ReaLTaiizor.Controls.GroupBox();
            this.txt_namepl = new ReaLTaiizor.Controls.AloneTextBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.aloneButton1 = new ReaLTaiizor.Controls.AloneButton();
            this.btn_ok = new ReaLTaiizor.Controls.AloneButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_themds.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(255, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(449, 350);
            this.flowLayoutPanel1.TabIndex = 16;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btn_taopl
            // 
            this.btn_taopl.BackColor = System.Drawing.Color.Transparent;
            this.btn_taopl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_taopl.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_taopl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_taopl.Image = null;
            this.btn_taopl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taopl.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_taopl.Location = new System.Drawing.Point(33, 459);
            this.btn_taopl.Name = "btn_taopl";
            this.btn_taopl.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_taopl.Size = new System.Drawing.Size(159, 35);
            this.btn_taopl.TabIndex = 18;
            this.btn_taopl.Text = "Tạo Playlist mới";
            this.btn_taopl.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_taopl.Click += new System.EventHandler(this.btn_taopl_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(349, 42);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(285, 46);
            this.bigLabel1.TabIndex = 19;
            this.bigLabel1.Text = "Danh sách bài hát";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(55, 42);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(122, 46);
            this.bigLabel2.TabIndex = 20;
            this.bigLabel2.Text = "Playlist";
            // 
            // groupBox_themds
            // 
            this.groupBox_themds.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_themds.BackGColor = System.Drawing.Color.DodgerBlue;
            this.groupBox_themds.BaseColor = System.Drawing.Color.Transparent;
            this.groupBox_themds.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBox_themds.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.groupBox_themds.Controls.Add(this.txt_namepl);
            this.groupBox_themds.Controls.Add(this.dungeonLabel1);
            this.groupBox_themds.Controls.Add(this.aloneButton1);
            this.groupBox_themds.Controls.Add(this.btn_ok);
            this.groupBox_themds.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox_themds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.groupBox_themds.HeaderColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox_themds.Location = new System.Drawing.Point(138, 186);
            this.groupBox_themds.MinimumSize = new System.Drawing.Size(136, 50);
            this.groupBox_themds.Name = "groupBox_themds";
            this.groupBox_themds.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.groupBox_themds.Size = new System.Drawing.Size(323, 148);
            this.groupBox_themds.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.groupBox_themds.TabIndex = 52;
            this.groupBox_themds.Text = "Tạo Playlist";
            this.groupBox_themds.Visible = false;
            // 
            // txt_namepl
            // 
            this.txt_namepl.BackColor = System.Drawing.Color.White;
            this.txt_namepl.EnabledCalc = true;
            this.txt_namepl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_namepl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txt_namepl.Location = new System.Drawing.Point(110, 37);
            this.txt_namepl.MaxLength = 32767;
            this.txt_namepl.MultiLine = false;
            this.txt_namepl.Name = "txt_namepl";
            this.txt_namepl.ReadOnly = false;
            this.txt_namepl.Size = new System.Drawing.Size(162, 29);
            this.txt_namepl.TabIndex = 4;
            this.txt_namepl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_namepl.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(28, 45);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(67, 21);
            this.dungeonLabel1.TabIndex = 3;
            this.dungeonLabel1.Text = "Playlist:";
            // 
            // aloneButton1
            // 
            this.aloneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aloneButton1.EnabledCalc = true;
            this.aloneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aloneButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.aloneButton1.Location = new System.Drawing.Point(182, 108);
            this.aloneButton1.Name = "aloneButton1";
            this.aloneButton1.Size = new System.Drawing.Size(73, 31);
            this.aloneButton1.TabIndex = 2;
            this.aloneButton1.Text = "Thoát";
            // 
            // btn_ok
            // 
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.EnabledCalc = true;
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btn_ok.Location = new System.Drawing.Point(53, 108);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(73, 31);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btn_ok_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 88);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(224, 352);
            this.flowLayoutPanel2.TabIndex = 53;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 531);
            this.Controls.Add(this.groupBox_themds);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.btn_taopl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Playlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlists";
            this.Load += new System.EventHandler(this.Playlist_Load);
            this.groupBox_themds.ResumeLayout(false);
            this.groupBox_themds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tlpMedia;
        private System.Windows.Forms.Panel panelSongInfo;
        private System.Windows.Forms.PictureBox pbSong;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        //private ReaLTaiizor.Controls.HopeTrackBar trackBar;
        private System.Windows.Forms.Label lbMaxTime;
        private System.Windows.Forms.Label lbMinTime;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox btnShuffer;
        private System.Windows.Forms.PictureBox btnRepeat;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.Panel panel12;
        //private ReaLTaiizor.Controls.HopeTrackBar trackbarVolume;
        private System.Windows.Forms.Timer tTrackBar;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPlaylist;
        private AxWMPLib.AxWindowsMediaPlayer mPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle2;
        private System.Windows.Forms.Panel panelTitle1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelContainer;
        //private ReaLTaiizor.Controls.HopeTabPage tabPageMedia;
        private System.Windows.Forms.TabPage tabPlaying;
        private System.Windows.Forms.Panel panelPlaying;
        private System.Windows.Forms.TabPage tabLyric;
        private System.Windows.Forms.RichTextBox rtbLyric;
        private System.Windows.Forms.Timer timerLyric;
        private System.Windows.Forms.Button btnKaraoke;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.Button btn_taopl;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.GroupBox groupBox_themds;
        private ReaLTaiizor.Controls.AloneTextBox txt_namepl;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.AloneButton aloneButton1;
        private ReaLTaiizor.Controls.AloneButton btn_ok;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}