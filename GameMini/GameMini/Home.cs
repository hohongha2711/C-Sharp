using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

namespace GameMini
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        // WMPLib.WindowsMediaPlayer wmplayer = new WMPLib.WindowsMediaPlayer();

        
        
        private void Home_Load(object sender, EventArgs e)
        {
            Panel pnlTop = new Panel() { Height = 2, Dock = DockStyle.Top, BackColor = Color.Green };
            this.Controls.Add(pnlTop);

            Panel pnlRight = new Panel() { Width = 2, Dock = DockStyle.Right, BackColor = Color.Green };
            this.Controls.Add(pnlRight);

            Panel pnlBottom = new Panel() { Height = 2, Dock = DockStyle.Bottom, BackColor = Color.Green };
            this.Controls.Add(pnlBottom);

            Panel pnlLeft = new Panel() { Width = 2, Dock = DockStyle.Left, BackColor = Color.Green };
            this.Controls.Add(pnlLeft);
            Share.Mute = false;
            pictureBox_Volume.Visible = true;
            pictureBox_Mute.Visible = false;
            //string path = Path.Combine(Directory.GetCurrentDirectory(),@"Resources/abc-song-loop-119706.mp3");
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(executableLocation, "abc-song-loop-119706.mp3");
            Console.WriteLine(path);
            Share.wmplayer.URL = path; //"D:/Nam3_HK1/C#/BTTH/GameMini/GameMini/Resources/abc-song-loop-119706.mp3";
            Share.wmplayer.controls.play();
            Share.wmplayer.settings.playCount = 10000000;
        }
       
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Share.wmplayer.controls.stop();
                this.Close();
            }
            else
            { }
        }

        private void pictureBox_Volume_Click(object sender, EventArgs e)
        {
            Share.Mute = true;
            pictureBox_Volume.Visible = false;
            pictureBox_Mute.Visible = true;
            Share.wmplayer.controls.pause();
        }

        private void pictureBox_Mute_Click(object sender, EventArgs e)
        {
            pictureBox_Volume.Visible = true;
            pictureBox_Mute.Visible = false;
            Share.Mute = false;
            Share.wmplayer.controls.play();
        }

        private void pictureBox_Rank_Click(object sender, EventArgs e)
        {
            Rank dlg = new Rank();
            this.Visible = false;
            dlg.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox_TuVung_Click(object sender, EventArgs e)
        {
            Vocabulary dlg = new Vocabulary();
            this.Visible = false;
            dlg.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox_Play_Click(object sender, EventArgs e)
        {
            Topic dgl = new Topic();
            this.Visible = false;
            dgl.ShowDialog();
            this.Visible=true;
        }

    }
}
