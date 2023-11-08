namespace GameMini
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox_Volume = new System.Windows.Forms.PictureBox();
            this.pictureBox_TuVung = new System.Windows.Forms.PictureBox();
            this.pictureBox_Rank = new System.Windows.Forms.PictureBox();
            this.lbl_TuVung = new System.Windows.Forms.Label();
            this.lbl_Rank = new System.Windows.Forms.Label();
            this.pictureBox_Play = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Click = new System.Windows.Forms.PictureBox();
            this.pictureBox_Mute = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TuVung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Volume
            // 
            this.pictureBox_Volume.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Volume.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Volume.Image")));
            this.pictureBox_Volume.Location = new System.Drawing.Point(15, 7);
            this.pictureBox_Volume.Name = "pictureBox_Volume";
            this.pictureBox_Volume.Size = new System.Drawing.Size(52, 52);
            this.pictureBox_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Volume.TabIndex = 18;
            this.pictureBox_Volume.TabStop = false;
            this.pictureBox_Volume.Click += new System.EventHandler(this.pictureBox_Volume_Click);
            // 
            // pictureBox_TuVung
            // 
            this.pictureBox_TuVung.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_TuVung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_TuVung.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TuVung.Image")));
            this.pictureBox_TuVung.Location = new System.Drawing.Point(15, 308);
            this.pictureBox_TuVung.Name = "pictureBox_TuVung";
            this.pictureBox_TuVung.Size = new System.Drawing.Size(81, 67);
            this.pictureBox_TuVung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TuVung.TabIndex = 13;
            this.pictureBox_TuVung.TabStop = false;
            this.pictureBox_TuVung.Click += new System.EventHandler(this.pictureBox_TuVung_Click);
            // 
            // pictureBox_Rank
            // 
            this.pictureBox_Rank.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_Rank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Rank.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Rank.Image")));
            this.pictureBox_Rank.Location = new System.Drawing.Point(15, 194);
            this.pictureBox_Rank.Name = "pictureBox_Rank";
            this.pictureBox_Rank.Size = new System.Drawing.Size(81, 75);
            this.pictureBox_Rank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Rank.TabIndex = 12;
            this.pictureBox_Rank.TabStop = false;
            this.pictureBox_Rank.Click += new System.EventHandler(this.pictureBox_Rank_Click);
            // 
            // lbl_TuVung
            // 
            this.lbl_TuVung.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TuVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TuVung.ForeColor = System.Drawing.Color.Red;
            this.lbl_TuVung.Location = new System.Drawing.Point(12, 378);
            this.lbl_TuVung.Name = "lbl_TuVung";
            this.lbl_TuVung.Size = new System.Drawing.Size(84, 23);
            this.lbl_TuVung.TabIndex = 17;
            this.lbl_TuVung.Text = "Learn";
            this.lbl_TuVung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Rank
            // 
            this.lbl_Rank.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Rank.ForeColor = System.Drawing.Color.Red;
            this.lbl_Rank.Location = new System.Drawing.Point(12, 272);
            this.lbl_Rank.Name = "lbl_Rank";
            this.lbl_Rank.Size = new System.Drawing.Size(82, 21);
            this.lbl_Rank.TabIndex = 16;
            this.lbl_Rank.Text = "Rank";
            this.lbl_Rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Play
            // 
            this.pictureBox_Play.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Play.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Play.Image")));
            this.pictureBox_Play.Location = new System.Drawing.Point(700, 497);
            this.pictureBox_Play.Name = "pictureBox_Play";
            this.pictureBox_Play.Size = new System.Drawing.Size(128, 106);
            this.pictureBox_Play.TabIndex = 14;
            this.pictureBox_Play.TabStop = false;
            this.pictureBox_Play.Click += new System.EventHandler(this.pictureBox_Play_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(837, 7);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(51, 49);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 11;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // pictureBox_Click
            // 
            this.pictureBox_Click.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Click.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Click.Image")));
            this.pictureBox_Click.Location = new System.Drawing.Point(614, 443);
            this.pictureBox_Click.Name = "pictureBox_Click";
            this.pictureBox_Click.Size = new System.Drawing.Size(180, 132);
            this.pictureBox_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Click.TabIndex = 15;
            this.pictureBox_Click.TabStop = false;
            // 
            // pictureBox_Mute
            // 
            this.pictureBox_Mute.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Mute.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Mute.Image")));
            this.pictureBox_Mute.Location = new System.Drawing.Point(15, 7);
            this.pictureBox_Mute.Name = "pictureBox_Mute";
            this.pictureBox_Mute.Size = new System.Drawing.Size(52, 52);
            this.pictureBox_Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Mute.TabIndex = 19;
            this.pictureBox_Mute.TabStop = false;
            this.pictureBox_Mute.Click += new System.EventHandler(this.pictureBox_Mute_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(27, 527);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(215, 48);
            this.axWindowsMediaPlayer1.TabIndex = 20;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Home
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 606);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBox_Volume);
            this.Controls.Add(this.pictureBox_TuVung);
            this.Controls.Add(this.pictureBox_Rank);
            this.Controls.Add(this.lbl_TuVung);
            this.Controls.Add(this.lbl_Rank);
            this.Controls.Add(this.pictureBox_Play);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.pictureBox_Click);
            this.Controls.Add(this.pictureBox_Mute);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TuVung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Volume;
        private System.Windows.Forms.PictureBox pictureBox_TuVung;
        private System.Windows.Forms.PictureBox pictureBox_Rank;
        private System.Windows.Forms.Label lbl_TuVung;
        private System.Windows.Forms.Label lbl_Rank;
        private System.Windows.Forms.PictureBox pictureBox_Play;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Click;
        private System.Windows.Forms.PictureBox pictureBox_Mute;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}