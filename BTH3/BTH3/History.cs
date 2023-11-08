using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panel = ReaLTaiizor.Controls.Panel;

namespace BTH3
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            load();
        }
        public static DataTable playlist_ds = new DataTable();
        DataRow[] dr_pl = Play.history.Select();
        void load()
        {
            //flowLayoutPanel1.FlowDirection = flowLayoutPanel1.FlowDirection;
            //flowLayoutPanel1.Refresh();
            DataTable playlist = new DataTable();

            playlist.Columns.Add("TenBaiHat", typeof(string));
            playlist.Columns.Add("CaSi", typeof(string));
            playlist.Columns.Add("TheLoai", typeof(string));
            playlist.Columns.Add("Anh", typeof(string));
            playlist.Columns.Add("DuongDan", typeof(string));
            playlist.Columns.Add("LoiBH", typeof(string));
            playlist.Columns.Add("LuotNghe", typeof(int));

            flowLayoutPanel1.Controls.Clear();
            int location = 0;
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Image img2 = Image.FromFile(Path.Combine(executableLocation, "icon\\playlist.png"));
            Image img1 = Image.FromFile(Path.Combine(executableLocation, "icon\\play.png"));
            Image img3 = Image.FromFile(Path.Combine(executableLocation, "icon\\dowload.png"));
            for (int i = 0; i < dr_pl.Length; i++)
            {
                Panel p = new Panel();
                p.Name = i.ToString();
                p.BackColor = Color.FromArgb(123, 123, 124);
                p.Size = new Size(flowLayoutPanel1.ClientSize.Width, 60);

                DataRow[] dtr = Play.dt.Select("TenBaiHat = '" + dr_pl[i]["TenBH"].ToString() + "'");
                playlist.Rows.Add(dtr[0]["TenBaiHat"], dtr[0]["CaSi"], dtr[0]["TheLoai"], dtr[0]["Anh"], dtr[0]["DuongDan"], dtr[0]["LoiBH"], dtr[0]["LuotNghe"]);
                //DataRow dtrow = dtr[0];
                //playlist.Rows.Add(dtrow);
                //Image img0 = Image."https://avatar-ex-swe.nixcdn.com/song/2022/10/16/5/e/5/8/1665899566109.jpg";
                //Image img0 = Image.FromFile("https://avatar-ex-swe.nixcdn.com/song/2022/10/16/5/e/5/8/1665899566109.jpg");
                //Image im = Image.U
                //p.Controls.Add(pic1);
                //PictureBox[] pipe = new PictureBox[2];
                PictureBox pic0 = new PictureBox();
                p.Controls.Add(pic0);
                pic0.Name = "picture" + i.ToString();
                pic0.Width = 50;
                pic0.Height = 50;
                pic0.BackColor = Color.Transparent;
                pic0.Top = 5;
                pic0.Left = 5;
                pic0.ImageLocation = dtr[0]["Anh"].ToString();
                pic0.SizeMode = PictureBoxSizeMode.StretchImage;


                Label lb_name = new Label();
                p.Controls.Add(lb_name);
                lb_name.Name = "Name" + i.ToString();
                lb_name.Text = dtr[0]["TenBaiHat"].ToString();
                lb_name.Width = 300;
                lb_name.Height = 20;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 5;
                lb_name.Left = 55;
                lb_name.Font = new Font("Times new roman", 13);

                Label lb_singer = new Label();
                p.Controls.Add(lb_singer);
                lb_singer.Name = "Casi" + i.ToString();
                lb_singer.Text = dtr[0]["CaSi"].ToString();
                lb_singer.Width = 300;
                lb_singer.Height = 20;
                lb_singer.BackColor = Color.Transparent;
                lb_singer.Top = 30;
                lb_singer.Left = 55;
                lb_singer.Font = new Font("Times new roman", 12);

                PictureBox pic1 = new PictureBox();
                p.Controls.Add(pic1);
                pic1.Name = "play" + i.ToString();
                pic1.Width = 40;
                pic1.Height = 40;
                pic1.BackColor = Color.Transparent;
                pic1.Top = 10;
                pic1.Left = 360;
                pic1.Image = img1;
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                pic1.Click += Pic_play_click;

                PictureBox pic2 = new PictureBox();
                p.Controls.Add(pic2);
                pic2.Name = "download" + i.ToString();
                pic2.Width = 40;
                pic2.Height = 40;
                pic2.BackColor = Color.Transparent;
                pic2.Top = 10;
                pic2.Left = 405;
                pic2.Image = img3;
                pic2.SizeMode = PictureBoxSizeMode.StretchImage;
                pic2.Click += download_click;

                Label lbl = new Label();
                p.Controls.Add(lbl);
                lbl.Name = "TG" + i.ToString();
                lbl.Text = "Thời gian";
                lbl.Width = 300;
                lbl.Height = 20;
                lbl.BackColor = Color.Transparent;
                lbl.Top = 5;
                lbl.Left = 470;
                lbl.Font = new Font("Times new roman", 13);

                Label lb = new Label();
                p.Controls.Add(lb);
                lb.Name = "Thoigian" + i.ToString();
                lb.Text = dr_pl[i]["Thoigian"].ToString();
                lb.Width = 300;
                lb.Height = 20;
                lb.BackColor = Color.Transparent;
                lb.Top = 30;
                lb.Left = 470;
                lb.Font = new Font("Times new roman", 12);
                img1 = Image.FromFile(Path.Combine(executableLocation, "icon\\play.png"));
                flowLayoutPanel1.Controls.Add(p);
                flowLayoutPanel1.Controls.SetChildIndex(p, location);  // this moves the new one to the top!
                location += 60;                                         // this is just for fun                                                            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font,Size = 14, Brushes.White, 2, 12); };
                flowLayoutPanel1.Invalidate();
            }
            playlist_ds = playlist;
        }
        private void download_click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            string s1 = pic.Name;
            string s = s1;
            s = s.Substring(8, s1.Length - 8);
            //MessageBox.Show(s);
            int i = Int32.Parse(s);

            SaveFileDialog savepdf = new SaveFileDialog();
            savepdf.Filter = "*.mp3|All files (*.*)";
            //DialogResult d = savepdf.ShowDialog();
            if (savepdf.ShowDialog() == DialogResult.OK)
            {
                string newDirectory = savepdf.FileName;
                DataRow[] dtr = Play.dt.Select("TenBaiHat = '" + dr_pl[i]["Song"].ToString() + "'");
                System.IO.File.Copy(dtr[0]["DuongDan"].ToString(), newDirectory + ".mp3");
                MessageBox.Show("Đã tải xong");
            }

        }
        public static int curr = 0;
        public static int fl_h = 0;
        private void Pic_play_click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            String s = pic.Name;
            s = s.Substring(4, s.Length - 4);
            curr = Int32.Parse(s);
            Play.flag = 2;
            Play.dr = playlist_ds.Select();
            this.Close();
        }
    }
}
