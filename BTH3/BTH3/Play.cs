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
using System.Xml.Linq;
using WMPLib;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint.BackColor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Panel = ReaLTaiizor.Controls.Panel;

namespace BTH3
{
    public partial class Play : Form
    {
        //public AxWMPLib.AxWindowsMediaPlayer MediaPlayer { get => mPlayer;}
        public Play()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        Timer t;
        int s = 0;
        public static DataRow[] dr;
        public static DataTable dt = new DataTable();
        public static DataTable playlist = new DataTable();
        public static DataTable dsplaylist = new DataTable();
        public static DataTable acc = new DataTable();
        public static DataTable love = new DataTable();
        public static DataTable history = new DataTable();
        public AxWMPLib.AxWindowsMediaPlayer MediaPlayer { get => mPlayer; }
        public static int login = 0;
        public static string name = "";
        public static string id = "";
        public static int flag = 0;
        //WMPLib.WindowsMediaPlayer mPlayer = new WMPLib.WindowsMediaPlayer();
        private void Play_Load(object sender, EventArgs e)
        {
            //acc
            if (flag == 0)
            {

                acc.Columns.Add("ID", typeof(string));
                acc.Columns.Add("MatKhau", typeof(string));
                acc.Columns.Add("Ten", typeof(string));

                dt.Columns.Add("TenBaiHat", typeof(string));
                dt.Columns.Add("CaSi", typeof(string));
                dt.Columns.Add("TheLoai", typeof(string));
                dt.Columns.Add("Anh", typeof(string));
                dt.Columns.Add("DuongDan", typeof(string));
                dt.Columns.Add("LoiBH", typeof(string));
                dt.Columns.Add("LuotNghe", typeof(int));

                dsplaylist.Columns.Add("Name", typeof(string));
                //dsplaylist.Columns.Add("SoLuong",typeof(int));
                dsplaylist.Columns.Add("ID", typeof(string));

                playlist.Columns.Add("Song", typeof(string));
                playlist.Columns.Add("Playlist", typeof(string));

                love.Columns.Add("TenBH", typeof(string));
                love.Columns.Add("TaiKhoan", typeof(string));


                acc.Rows.Add("user", "matkhau", "Hồng Hà");

                history.Columns.Add("TenBH", typeof(string));
                history.Columns.Add("Thoigian", typeof(string));
                history.Columns.Add("TaiKhoan", typeof(string));

                //history.Rows.Add("Ngàn Thu",DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"),"user");

                dsplaylist.Rows.Add("Playlist1", "user");
                dsplaylist.Rows.Add("Playlist2", "user");
                //Playlist

                playlist.Rows.Add("Ngàn Thu", "Playlist1");
                playlist.Rows.Add("Em Là", "Playlist1");

                //love

                love.Rows.Add("Ngàn Thu", "user");

                //
                dt.Rows.Add("Waiting For You", "MONO | Onionn", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/08/10/4/8/b/1/1660104031203.jpg", "Music\\Nhactre\\1.mp3", "Music\\Nhactre\\1.txt", 827);
                dt.Rows.Add("dự báo thời tiết hôm nay mưa", "GREY D", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/11/14/4/3/5/a/1668400800081.jpg", "Music\\Nhactre\\2.mp3", "Music\\Nhactre\\2.txt", 586);
                dt.Rows.Add("Người Tình Mùa Đông", "Đức Phúc | MONO | DTAP", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/11/29/8/9/b/8/1669712534560.jpg", "Music\\Nhactre\\3.mp3", "Music\\Nhactre\\3.txt", 165);
                dt.Rows.Add("Chuyện Đôi Ta", "Emcee L | Muộii", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2021/11/25/8/7/5/6/1637809824703.jpg", "Music\\Nhactre\\4.mp3", "Music\\Nhactre\\4.txt", 847);
                dt.Rows.Add("Ngàn Thu", "Toky", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/11/15/8/2/d/b/1668521414130.jpg", "Music\\Nhactre\\5.mp3", "Music\\Nhactre\\5.txt", 96);
                dt.Rows.Add("Cuối Cùng Thì", "Jack - J97", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/11/07/e/d/4/3/1667802740293.jpg", "Music\\Nhactre\\6.mp3", "Music\\Nhactre\\6.txt", 82);
                dt.Rows.Add("Em Là", "MONO | Onionn", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/08/10/4/8/b/1/1660119775021.jpg", "Music\\Nhactre\\7.mp3", "Music\\Nhactre\\7.txt", 758);
                dt.Rows.Add("Chưa Quên Người Yêu Cũ", "Hà Nhi", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/07/28/3/b/5/b/1658997436153.jpg", "Music\\Nhactre\\8.mp3", "Music\\Nhactre\\8.txt", 348);
                dt.Rows.Add("Người Như Anh", "Mai Tiến Dũng", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/10/20/2/4/1/e/1666252139527.jpg", "Music\\Nhactre\\9.mp3", "Music\\Nhactre\\9.txt", 855);
                dt.Rows.Add("Bài Này Không Để Đi Diễn", "Anh Tú Atus", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/10/17/b/9/5/f/1665981317873.jpg", "Music\\Nhactre\\10.mp3", "Music\\Nhactre\\10.txt", 179);
                dt.Rows.Add("Cô Đơn Trên Sofa", "Hồ Ngọc Hà", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/10/19/7/1/f/4/1666185034236.jpg", "Music\\Nhactre\\11.mp3", "Music\\Nhactre\\11.txt", 118);
                dt.Rows.Add("Vaicaunoicokhiennguoithaydoi", "GREY D | tlinh", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/06/20/f/c/8/c/1655699296267.jpg", "Music\\Nhactre\\12.mp3", "Music\\Nhactre\\12.txt", 603);
                dt.Rows.Add("Anh Tự Do Nhưng Cô Đơn", "Trung Quân", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/11/10/7/f/f/e/1668054031624.jpg", "Music\\Nhactre\\13.mp3", "Music\\Nhactre\\13.txt", 6);
                dt.Rows.Add("Người Thầy Vùng Cao", "Danh Zoram", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/11/08/8/9/e/f/1667919866497.jpg", "Music\\Nhactre\\14.mp3", "Music\\Nhactre\\14.txt", 926);
                dt.Rows.Add("Nếu Có Quay Lại", "Anh Khoa", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/11/23/8/a/9/3/1669216899218.jpg", "Music\\Nhactre\\15.mp3", "Music\\Nhactre\\15.txt", 784);
                dt.Rows.Add("Sao Cũng Được", "Thành Đạt", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2022/10/16/5/e/5/8/1665933114579.jpg", "Music\\Nhactre\\16.mp3", "Music\\Nhactre\\16.txt", 846);
                dt.Rows.Add("Dù Cho Mai Về Sau(Acoustic Version)", "buitruonglinh", "Nhạc trẻ", "https://avatar-ex-swe.nixcdn.com/song/2020/11/30/f/f/2/6/1606727675173.jpg", "Music\\Nhactre\\17.mp3", "Music\\Nhactre\\17.txt", 639);

                dt.Rows.Add("Say Đắm Trong Lần Đầu (Sped Up)", "JBEE|Winno", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2022/11/30/d/4/5/0/1669799297586.jpg", "Music\\Remix\\1.mp3", "Music\\Remix\\1.txt", 803);
                dt.Rows.Add("Trót Trao Duyên (Bibo Remix)", "NB3 Hoài Bảo", "Remix", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2020/04/20/d/1/1/3/1587347492345.jpg", "Music\\Remix\\2.mp3", "Music\\Remix\\2.txt", 99);
                dt.Rows.Add("Phong Dạ Hành (Remix)", "BT|LVT", "Remix", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2016/01/25/4/1/1/7/1453716528663.jpg", "Music\\Remix\\3.mp3", "Music\\Remix\\3.txt", 196);
                dt.Rows.Add("Lỡ Duyên Kiếp Này, Liệu Có Kiếp Sau (Ciray Remix)", "Khả Hiệp", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2022/11/23/2/7/8/f/1669187624765.jpg", "Music\\Remix\\4.mp3", "Music\\Remix\\4.txt", 783);
                dt.Rows.Add("Hạ Cánh (Teddy Remix)", "RZ Mas|Not Afraid|Chariot", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2022/10/31/8/3/d/0/1667209408452.jpg", "Music\\Remix\\5.mp3", "Music\\Remix\\5.txt", 435);
                dt.Rows.Add("Dĩ Vãng Nhạt Nhòa", "Hà Nhi", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2018/11/12/7/f/3/1/1542009008716.jpg", "Music\\Remix\\6.mp3", "Music\\Remix\\6.txt", 534);
                dt.Rows.Add("Cuối Cùng Thì (Cukak Remix)", "Jack - J97", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2022/11/10/5/a/f/2/1668040052225.jpg", "Music\\Remix\\7.mp3", "Music\\Remix\\7.txt", 797);
                dt.Rows.Add("Tấm Lòng Son (Remix)", "H-Kray|Đại Mèo", "Remix", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2021/07/29/e/d/6/0/1627519632288.jpg", "Music\\Remix\\8.mp3", "Music\\Remix\\8.txt", 501);
                dt.Rows.Add("Lonely Remix", "Nana|BT", "Remix", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2022/09/17/3/4/2/d/1663428394740.jpg", "Music\\Remix\\9.mp3", "Music\\Remix\\9.txt", 684);
                dt.Rows.Add("Thuyền Quyên (Am Remix)", "Diệu Kiên", "Remix", "https://stc-id.nixcdn.com/v11/images/avatar_default.jpg", "Music\\Remix\\10.mp3", "Music\\Remix\\10.txt", 609);
                dt.Rows.Add("Không Cần Phải Nói Nhiều (CM1X Remix)", "tlinh|Hoàng Tôn", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2022/11/30/d/4/5/0/1669775499597.jpg", "Music\\Remix\\11.mp3", "Music\\Remix\\11.txt", 615);
                dt.Rows.Add("Giang Hải Không Độ Nàng (Orinn Remix)", "Gia Huy Singer", "Remix", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2018/01/09/e/0/3/1/1515463327333.jpg", "Music\\Remix\\12.mp3", "Music\\Remix\\12.txt", 178);
                dt.Rows.Add("Vô Lượng (Trích Chú Đại Bi)", "Masew|Khôi Vũ", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2022/10/26/9/2/5/2/1666759798771.jpg", "Music\\Remix\\13.mp3", "Music\\Remix\\13.txt", 776);
                dt.Rows.Add("Anh Yêu Em Cực (CM1X Remix)", "Linh Thộn|Minh Vũ", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2022/10/24/a/8/3/1/1666587124110.jpg", "Music\\Remix\\14.mp3", "Music\\Remix\\14.txt", 248);
                dt.Rows.Add("Em Ơi Đừng Khóc (Remix)", "Tăng Duy Tân", "Remix", "https://avatar-ex-swe.nixcdn.com/song/2022/07/15/2/5/0/1/1657856771820.jpg", "Music\\Remix\\15.mp3", "Music\\Remix\\15.txt", 495);

                dt.Rows.Add("Thói Đời", "Đan Nguyên", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2017/03/24/8/2/a/2/1490321288901.jpg", "Music\\Trutinh\\1.mp3", "Music\\Trutinh\\1.txt", 526);
                dt.Rows.Add("Người Yêu Cô Đơn", "Đan Nguyên", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2014/12/16/b/e/5/a/1418719375492.jpg", "Music\\Trutinh\\2.mp3", "Music\\Trutinh\\2.txt", 560);
                dt.Rows.Add("Vùng Lá Me Bay", "Dương Hồng Loan", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2017/03/02/d/a/2/4/1488425858082.jpg", "Music\\Trutinh\\3.mp3", "Music\\Trutinh\\3.txt", 82);
                dt.Rows.Add("Bông Điên Điển", "Phi Nhung", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2018/01/11/8/a/6/c/1515660718081.jpg", "Music\\Trutinh\\4.mp3", "Music\\Trutinh\\4.txt", 517);
                dt.Rows.Add("Duyên Phận", "Dương Hồng Loan", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2015/10/08/5/5/c/4/1444278941099.jpg", "Music\\Trutinh\\5.mp3", "Music\\Trutinh\\5.txt", 484);
                dt.Rows.Add("Đường Tình Đôi Ngã", "Giáng Tiên|Dương Ngọc Thái", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2016/01/25/4/1/1/7/1453715646175.jpg", "Music\\Trutinh\\6.mp3", "Music\\Trutinh\\6.txt", 575);
                dt.Rows.Add("Đắp Mộ Cuộc Tình", "Đan Nguyên", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2017/03/24/8/2/a/2/1490321288901.jpg", "Music\\Trutinh\\7.mp3", "Music\\Trutinh\\7.txt", 88);
                dt.Rows.Add("Lại Nhớ Người Yêu", "Lưu Ánh Loan|Đoàn Minh", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2017/01/04/6/1/b/5/1483498974352.jpg", "Music\\Trutinh\\8.mp3", "Music\\Trutinh\\8.txt", 769);
                dt.Rows.Add("Chuyện Tình Người Đan Áo", "Quang Lê|Mai Thiên Vân", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2017/02/06/3/4/7/f/1486358917132.jpg", "Music\\Trutinh\\9.mp3", "Music\\Trutinh\\9.txt", 879);
                dt.Rows.Add("Hoa Nở Về Đêm", "Lệ Quyên", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2015/03/11/b/9/0/7/1426057073463.jpg", "Music\\Trutinh\\10.mp3", "Music\\Trutinh\\10.txt", 947);
                dt.Rows.Add("Chuyện Hẹn Hò", "Quang Lê", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2013/11/06/c/c/a/8/1383712898755.jpg", "Music\\Trutinh\\11.mp3", "Music\\Trutinh\\11.txt", 342);
                dt.Rows.Add("Đôi Mắt Người Xưa", "Đan Nguyên", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2013/11/06/c/c/a/8/1383710746279.jpg", "Music\\Trutinh\\12.mp3", "Music\\Trutinh\\12.txt", 786);
                dt.Rows.Add("Sầu Tím Thiệp Hồng", "Huỳnh Nguyễn Công Bằng|Dương Hồng Loan", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2014/01/16/2/8/0/1/1389842122665.jpg", "Music\\Trutinh\\13.mp3", "Music\\Trutinh\\13.txt", 288);
                dt.Rows.Add("Căn Nhà Màu Tím", "Đan Nguyên", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/song/2013/11/06/c/c/a/8/1383710746279.jpg", "Music\\Trutinh\\14.mp3", "Music\\Trutinh\\14.txt", 755);
                dt.Rows.Add("Bậu Ơi Đừng Khóc", "Phi Nhung", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2018/01/11/8/a/6/c/1515660718081.jpg", "Music\\Trutinh\\15.mp3", "Music\\Trutinh\\15.txt", 582);
                dt.Rows.Add("Hoa Nở Về Đêm", "Như Quỳnh", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2018/11/28/b/a/d/9/1543393481989.jpg", "Music\\Trutinh\\16.mp3", "Music\\Trutinh\\16.txt", 975);
                dt.Rows.Add("Túy Ca", "Đan Nguyên", "Trữ tình", "https://avatar-ex-swe.nixcdn.com/singer/avatar/2017/03/24/8/2/a/2/1490321288901.jpg", "Music\\Trutinh\\17.mp3", "Music\\Trutinh\\17.txt", 945);


                dr = dt.Select();

                load(0);


                //axWindowsMediaPlayer1 = (AxWMPLib.AxWindowsMediaPlayer)mPlayer;
                //mPlayer.Ctlcontrols.stop();
                t = new Timer();
                t.Interval = 1000;
                t.Tick += new EventHandler(t_Tick);
            }
            else if (flag == 1)
            {
                dr = Playlist.playlist_ds.Select();
                load(0);
            }
            else
            {
                dr = History.playlist_ds.Select();
                load(0);
            }
        }
        //hopeTrackBar1.Tick += new EventHandler(tTrackBar_Tick);

        //this.tTrackBar = new System.Windows.Forms.Timer(this.components);





        void t_Tick(object sender, EventArgs e)
        {
            if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (barChange)
                    hopeTrackBar1.Value = (int)mPlayer.Ctlcontrols.currentPosition;
            }
        }

        //Label lb_name;
        void load(int k)
        {

            //flowLayoutPanel1.FlowDirection = flowLayoutPanel1.FlowDirection;
            //flowLayoutPanel1.Refresh();
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(executableLocation, dr[k]["DuongDan"].ToString());
            mPlayer.URL = path;
            if (flag != 0)
            {
                mPlayer.Ctlcontrols.play();
                pictureBox_Play.Visible = false;
                pictureBox_Pause.Visible = true;
            }
            else
            {
                mPlayer.Ctlcontrols.stop();
                pictureBox_Play.Visible = true;
                pictureBox_Pause.Visible = false;
            }
            pic_play.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_play.ImageLocation = dr[k]["Anh"].ToString();
            label_name.Text = dr[k]["TenBaiHat"].ToString();
            label_singer.Text = dr[k]["CaSi"].ToString();
            lbl_nghe.Text = dr[k]["LuotNghe"].ToString();
            richTextBox1.Text = File.ReadAllText(Path.Combine(executableLocation,dr[k]["LoiBH"].ToString()));
            if (check(label_name.Text) == 1)
            {
                pictureBox_unlove.Visible = true;
                pictureBox_love.Visible = false;
            }
            else
            {
                pictureBox_unlove.Visible = false;
                pictureBox_love.Visible = true;
            }
            hopeTrackBar1.Value = 0;
            flowLayoutPanel1.Controls.Clear();
            int location = 0;
            Image img2 = Image.FromFile(Path.Combine(executableLocation,"icon\\playlist.png"));
            Image img1 = Image.FromFile(Path.Combine(executableLocation, "icon\\play.png"));
            Image img3 = Image.FromFile(Path.Combine(executableLocation, "icon\\dowload.png"));
            for (int i = 0; i < dr.Length; i++)
            {
                Panel p = new Panel();
                p.Name = i.ToString();
                p.BackColor = Color.FromArgb(123, 123, 124);
                p.Size = new Size(flowLayoutPanel1.ClientSize.Width, 60);

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
                pic0.ImageLocation = dr[i]["Anh"].ToString();
                pic0.SizeMode = PictureBoxSizeMode.StretchImage;


                Label lb_name = new Label();
                p.Controls.Add(lb_name);
                lb_name.Name = "Name" + i.ToString();
                lb_name.Text = dr[i]["TenBaiHat"].ToString();
                lb_name.Width = 300;
                lb_name.Height = 20;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 5;
                lb_name.Left = 55;
                lb_name.Font = new Font("Times new roman", 13);

                Label lb_singer = new Label();
                p.Controls.Add(lb_singer);
                lb_name.Name = "Casi" + i.ToString();
                lb_singer.Text = dr[i]["CaSi"].ToString();
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
                pic2.Name = "list" + i.ToString();
                pic2.Width = 40;
                pic2.Height = 40;
                pic2.BackColor = Color.Transparent;
                pic2.Top = 10;
                pic2.Left = 405;
                pic2.Image = img2;
                pic2.SizeMode = PictureBoxSizeMode.StretchImage;
                pic2.Click += playlist_click;

                PictureBox pic3 = new PictureBox();
                p.Controls.Add(pic3);
                pic3.Name = "download" + i.ToString();
                pic3.Width = 40;
                pic3.Height = 40;
                pic3.BackColor = Color.Transparent;
                pic3.Top = 10;
                pic3.Left = 450;
                pic3.Image = img3;
                pic3.SizeMode = PictureBoxSizeMode.StretchImage;
                pic3.Click += download_click;


                flowLayoutPanel1.Controls.Add(p);
                flowLayoutPanel1.Controls.SetChildIndex(p, location);  // this moves the new one to the top!
                location += 60;                                         // this is just for fun                                                            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font,Size = 14, Brushes.White, 2, 12); };
                flowLayoutPanel1.Invalidate();
            }
        }

        int check_tontai(string s, string s1, DataTable data)
        {
            DataRow[] drr = data.Select();
            for (int i = 0; i < drr.Length; i++)
                if (drr[i][0].ToString() == s && drr[i][1].ToString() == s1)
                    return 1;
            return 0;
        }
        int cur = -1;
        string tenbh = "";
        private void playlist_click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (login == 0)
            {
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
            string s1 = pic.Name;
            string s = s1;
            s = s.Substring(4, s.Length - 4);
            int j = Int32.Parse(s);
            tenbh = dr[j]["TenBaiHat"].ToString();
            groupBox_them.Visible = true;
            DataRow[] d = dsplaylist.Select();
            flowLayoutPanel2.Controls.Clear();
            int location = 0;
            for (int i = 0; i < d.Length; i++)
            {
                Panel panel = new Panel();
                panel.Name = "Playlist" + i.ToString();
                panel.Size = new Size(flowLayoutPanel2.ClientSize.Width, 60);
                panel.BackColor = Color.FromArgb(123, 123, 124);
                panel.Text = d[i]["Name"].ToString();
                panel.Font = new Font("Times new roman", 14);
                //panel.Height = 50;
                //panel.Width = 200;
                //btn.BackColor = Color.Red;
                panel.Top = 10;
                //panel.Left = 50;
                panel.Click += panel_click;

                Label lb_name = new Label();
                panel.Controls.Add(lb_name);
                lb_name.Name = "Name" + i.ToString();
                lb_name.Text = d[i]["Name"].ToString();
                lb_name.AutoSize = true;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 20;
                lb_name.Left = 100;
                lb_name.Font = new Font("Times new roman", 14);

                flowLayoutPanel2.Controls.Add(panel);
                flowLayoutPanel2.Controls.SetChildIndex(panel, location);
                location += 60;
                flowLayoutPanel2.Invalidate();
            }
        }

        private void panel_click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            string t = p.Text;
            if (check_tontai(tenbh,t, playlist) == 0)
            {
                playlist.Rows.Add(tenbh, t);
                MessageBox.Show("Đã thêm bài hát " + tenbh + " vào " + t);
            }
            else
            {
                MessageBox.Show("Bài hát " + tenbh + " đã tồn tại trong " + t);
            }
            groupBox_them.Visible = false;
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
                string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                System.IO.File.Copy(Path.Combine(executableLocation, dr[i]["DuongDan"].ToString()), newDirectory + ".mp3");
                MessageBox.Show("Đã tải xong");
            }

        }
        private void Pic_play_click(object sender, EventArgs e)
        {

            PictureBox pic = (PictureBox)sender;
            string s1 = pic.Name;
            string s = s1;
            s = s.Substring(4, s.Length - 4);
            int i = Int32.Parse(s);
            //string name = "Name" + i.ToString();
            //string casi = "Name" + i.ToString();
            //foreach ( Control p in flowLayoutPanel1.Controls)
            //    if(p.Name == i.ToString())
            //        foreach (Control p1 in p.Controls)
            //        {

            //        }    


            //MessageBox.Show(cur.ToString() +"\n"+ i.ToString());
            //Image image = pic.Image;
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Image img = Image.FromFile(Path.Combine(executableLocation, "icon\\pause.png"));
            label_name.Text = dr[i]["TenBaiHat"].ToString();
            label_singer.Text = dr[i]["CaSi"].ToString();
            //string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            
            richTextBox1.Text = File.ReadAllText(Path.Combine(executableLocation, dr[i]["LoiBH"].ToString()));
            pic_play.ImageLocation = dr[i]["Anh"].ToString();
            if (check(label_name.Text) == 1)
            {
                pictureBox_unlove.Visible = true;
                pictureBox_love.Visible = false;
            }
            else
            {
                pictureBox_unlove.Visible = false;
                pictureBox_love.Visible = true;
            }
            if (cur == i)
            {
                //load(0);
                cur = -1;
                //pic.ImageLocation = "D:\\Nam3_HK1\\C#\\BTTH\\Bai3\\play.png";
                pictureBox_Pause.Visible = false;
                pictureBox_Play.Visible = true;
                mPlayer.Ctlcontrols.pause();
            }
            else
            {
                cur = i;
                //load(i);
                //pic.Image = img;
                //string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string path = Path.Combine(executableLocation, dr[i]["DuongDan"].ToString());
                mPlayer.URL = path;

                pictureBox_Pause.Visible = true;
                pictureBox_Play.Visible = false;
                mPlayer.Ctlcontrols.play();
            }
            if (login != 0)
                if (check_tontai1(tenbh,history) == 0)
                {
                    history.Rows.Add(dr[i]["TenBaiHat"].ToString(), DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"), id);
                }
        }

        int check_tontai1(string s, DataTable history)
        {
            DataRow[] drr = history.Select();
            for (int i = 0; i < drr.Length; i++)
                if (drr[i][0].ToString() == s )
                    return 1;
            return 0;
        }

        private void pictureBox_Play_Click(object sender, EventArgs e)
        {
            pictureBox_Pause.Visible = true;
            pictureBox_Play.Visible = false;
            mPlayer.Ctlcontrols.play();
            if (check(label_name.Text) == 1)
            {
                pictureBox_unlove.Visible = true;
                pictureBox_love.Visible = false;
            }
            else
            {
                pictureBox_unlove.Visible = false;
                pictureBox_love.Visible = true;
            }
            //load(cur);
        }

        private void mPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                hopeTrackBar1.MaxValue = (int)mPlayer.Ctlcontrols.currentItem.duration;
                t.Start();
            }
            else if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                t.Stop();
            }
            else if (mPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                t.Stop();
                hopeTrackBar1.Value = 0;
            }
        }

        private bool barChange = true;

        private void hopeTrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mPlayer.currentMedia != null)
            {
                double cur = mPlayer.Ctlcontrols.currentItem.duration * e.X / (hopeTrackBar1.Width - 15);
                mPlayer.Ctlcontrols.currentPosition = cur;
                barChange = true;
                t.Start();
            }
        }


        private void hopeTrackBar1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mPlayer.currentMedia != null && e.Button == MouseButtons.Left)
            {
                barChange = false;
            }
        }

        private void hoptrackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            int newVol = 100 * e.X / (hoptrackBar2.Width - 15);
            mPlayer.settings.volume = newVol;
            hoptrackBar2.Value = newVol;
        }

        private void hoptrackBar2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mPlayer.settings.volume = hoptrackBar2.Value;
            }

        }

        private void pictureBox_Pause_Click(object sender, EventArgs e)
        {
            pictureBox_Pause.Visible = false;
            pictureBox_Play.Visible = true;
            mPlayer.Ctlcontrols.pause();
            //load(0);
        }

        private void pictureBox_Next_Click(object sender, EventArgs e)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            pictureBox_Pause.Visible = true;
            pictureBox_Play.Visible = false;
            if (s < dr.Length - 1)
            {
                s = s + 1;
               
                string path = Path.Combine(executableLocation, dr[s]["DuongDan"].ToString());
                mPlayer.URL = path;
            }
            else
            {
                //string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string path = Path.Combine(executableLocation, dr[s]["DuongDan"].ToString());
                mPlayer.URL = path;
            }
            pic_play.ImageLocation = dr[s]["Anh"].ToString();
            label_name.Text = dr[s]["TenBaiHat"].ToString();
            label_singer.Text = dr[s]["CaSi"].ToString();
            richTextBox1.Text = File.ReadAllText(Path.Combine(executableLocation, dr[s]["LoiBH"].ToString()));
            if (check(label_name.Text) == 1)
            {
                pictureBox_unlove.Visible = true;
                pictureBox_love.Visible = false;
            }
            else
            {
                pictureBox_unlove.Visible = false;
                pictureBox_love.Visible = true;
            }
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            pictureBox_Pause.Visible = true;
            pictureBox_Play.Visible = false;
            if (s > 0)
            {
                s = s - 1;
               
                string path = Path.Combine(executableLocation, dr[s]["DuongDan"].ToString());
                mPlayer.URL = path;
            }
            else
            {
                //string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string path = Path.Combine(executableLocation, dr[s]["DuongDan"].ToString());
                mPlayer.URL = path;
            }
            pic_play.ImageLocation = dr[s]["Anh"].ToString();
            label_name.Text = dr[s]["TenBaiHat"].ToString();
            label_singer.Text = dr[s]["CaSi"].ToString();
            richTextBox1.Text = File.ReadAllText(Path.Combine(executableLocation, dr[s]["LoiBH"].ToString()));
            if (check(label_name.Text) == 1)
            {
                pictureBox_unlove.Visible = true;
                pictureBox_love.Visible = false;
            }
            else
            {
                pictureBox_unlove.Visible = false;
                pictureBox_love.Visible = true;
            }
        }

        private void pictureBox_dowload_Click(object sender, EventArgs e)
        {

            SaveFileDialog savepdf = new SaveFileDialog();
            savepdf.Filter = "*.mp3|All files (*.*)";
            //DialogResult d = savepdf.ShowDialog();
            if (savepdf.ShowDialog() == DialogResult.OK)
            {
                string newDirectory = savepdf.FileName;
                System.IO.File.Copy(dr[s]["DuongDan"].ToString(), newDirectory + ".mp3");
                MessageBox.Show("Đã tải xong");
            }

        }

        private void pic_acc_Click(object sender, EventArgs e)
        {
            if (login == 0)
            {
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            btn_NhacTre.BackColor = Color.MediumSlateBlue;
            btn_Remix.BackColor = Color.MediumSlateBlue;
            btn_TruTinh.BackColor = Color.MediumSlateBlue;
            Playlist.pl_flag++;
            if (login == 0)
            {
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
            Playlist pl = new Playlist();
            this.Hide();
            pl.ShowDialog();
            this.Show();
            load(Playlist.current);
        }

        private void pictureBox_unlove_Click(object sender, EventArgs e)
        {
            pictureBox_love.Visible = true;
            pictureBox_unlove.Visible = false;
            DataRow[] drr = love.Select("TenBH='" + label_name.Text + "'");
            for (int i = 0; i < drr.Length; i++)
                drr[i].Delete();
            love.AcceptChanges();
        }

        private void pictureBox_love_Click(object sender, EventArgs e)
        {
            if (login == 0)
            {
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
            else
            {
                love.Rows.Add(label_name.Text, id);
                pictureBox_love.Visible = false;
                pictureBox_unlove.Visible = true;
            }

        }

        int check(string s)
        {
            DataRow[] dr_love = love.Select();
            for (int i = 0; i < dr_love.Length; i++)
            {
                if (dr_love[i]["TenBH"].ToString() == s && dr_love[i]["TaiKhoan"].ToString() == id)
                    return 1;
            }
            return 0;
        }

        private void btn_NhacTre_Click(object sender, EventArgs e)
        {
            btn_NhacTre.BackColor = Color.GreenYellow;
            btn_Remix.BackColor = Color.MediumSlateBlue;
            btn_TruTinh.BackColor = Color.MediumSlateBlue;
            dr = dt.Select("TheLoai = 'Nhạc Trẻ'");
            label1.Text = "Nhạc trẻ";
            load(0);
        }

        private void btn_Remix_Click(object sender, EventArgs e)
        {
            btn_NhacTre.BackColor = Color.MediumSlateBlue;
            btn_Remix.BackColor = Color.GreenYellow;
            btn_TruTinh.BackColor = Color.MediumSlateBlue;
            dr = dt.Select("TheLoai = 'Remix'");
            label1.Text = "Nhạc Remix";
            load(0);
        }

        private void btn_TruTinh_Click(object sender, EventArgs e)
        {
            label1.Text = "Nhạc Trữ tình";
            btn_NhacTre.BackColor = Color.MediumSlateBlue;
            btn_Remix.BackColor = Color.MediumSlateBlue;
            btn_TruTinh.BackColor = Color.GreenYellow;
            dr = dt.Select("TheLoai = 'Trữ tình'");
            load(0);
        }

        private void btn_DaThich_Click(object sender, EventArgs e)
        {
            btn_NhacTre.BackColor = Color.MediumSlateBlue;
            btn_Remix.BackColor = Color.MediumSlateBlue;
            btn_TruTinh.BackColor = Color.MediumSlateBlue;
            if (login == 0)
            {
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
            else
            {
                DataTable dathich = new DataTable();

                dathich.Columns.Add("TenBaiHat", typeof(string));
                dathich.Columns.Add("CaSi", typeof(string));
                dathich.Columns.Add("TheLoai", typeof(string));
                dathich.Columns.Add("Anh", typeof(string));
                dathich.Columns.Add("DuongDan", typeof(string));
                dathich.Columns.Add("LoiBH", typeof(string));
                dathich.Columns.Add("LuotNghe", typeof(int));
                DataRow[] dr_love = love.Select("TaiKhoan = '" + id + "'");
                for (int i = 0; i < dr_love.Length; i++)
                {
                    DataRow[] dtr = Play.dt.Select("TenBaiHat = '" + dr_love[i]["TenBH"].ToString() + "'");
                    dathich.Rows.Add(dtr[0]["TenBaiHat"], dtr[0]["CaSi"], dtr[0]["TheLoai"], dtr[0]["Anh"], dtr[0]["DuongDan"], dtr[0]["LoiBH"], dtr[0]["LuotNghe"]);
                }
                label1.Text = "Danh sách yêu thích";
                dr = dathich.Select();
                load(0);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            groupBox_them.Visible = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            groupBox_them.Visible = false;
            groupBox_themds.Visible = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            string t = txt_namepl.Text;
            dsplaylist.Rows.Add(t, id);
            if (check_tontai(tenbh, t ,playlist) == 0)
            {
                playlist.Rows.Add(tenbh, t);
                MessageBox.Show("Đã thêm bài hát " + tenbh + " vào " + t);
            }
            else
            {
                MessageBox.Show("Bài hát " + tenbh + " đã tồn tại trong " + t);
            }
            groupBox_themds.Visible = false;
        }

        private void aloneButton1_Click(object sender, EventArgs e)
        {
            groupBox_themds.Visible = false;
        }

        private void search(string s)
        {
            dr = dt.Select("TenBaiHat like '%" + s + "%' OR CaSi like '%" + s + "%' OR TheLoai like '%" + s + "%'");
            load(0);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void Play_Click(object sender, EventArgs e)
        {

            textBox1.ForeColor = Color.Silver;
            textBox1.Text = "Tìm kiếm...";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btn_NhacTre.BackColor = Color.MediumSlateBlue;
            btn_Remix.BackColor = Color.MediumSlateBlue;
            btn_TruTinh.BackColor = Color.MediumSlateBlue;
            label1.Text = "";
            search(textBox1.Text);
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            btn_NhacTre.BackColor = Color.MediumSlateBlue;
            btn_Remix.BackColor = Color.MediumSlateBlue;
            btn_TruTinh.BackColor = Color.MediumSlateBlue;
            label1.Text = "Danh sách đã nghe";
            if (login == 0)
            {
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }
            else
            {
                History dn = new History();
                this.Hide();
                dn.ShowDialog();
                this.Show();
                load(History.curr);
                //DataTable dathich = new DataTable();

                //dathich.Columns.Add("TenBaiHat", typeof(string));
                //dathich.Columns.Add("CaSi", typeof(string));
                //dathich.Columns.Add("TheLoai", typeof(string));
                //dathich.Columns.Add("Anh", typeof(string));
                //dathich.Columns.Add("DuongDan", typeof(string));
                //dathich.Columns.Add("LoiBH", typeof(string));
                //dathich.Columns.Add("LuotNghe", typeof(int));
                //DataRow[] dr_love = history.Select("TaiKhoan = '" + id + "'");
                //for (int i = 0; i < dr_love.Length; i++)
                //{
                //    DataRow[] dtr = Play.dt.Select("TenBaiHat = '" + dr_love[i]["TenBH"].ToString() + "'");
                //    dathich.Rows.Add(dtr[0]["TenBaiHat"], dtr[0]["CaSi"], dtr[0]["TheLoai"], dtr[0]["Anh"], dtr[0]["DuongDan"], dtr[0]["LoiBH"], dtr[0]["LuotNghe"]);
                //}
                //label1.Text = "Danh sách yêu thích";
                //dr = dathich.Select();
                //load2();
            }
        }
        void load2(int k)
        {

            //flowLayoutPanel1.FlowDirection = flowLayoutPanel1.FlowDirection;
            //flowLayoutPanel1.Refresh();
            mPlayer.URL = dr[k]["DuongDan"].ToString();
            if (flag != 0)
            {
                mPlayer.Ctlcontrols.play();
                pictureBox_Play.Visible = false;
                pictureBox_Pause.Visible = true;
            }
            else
            {
                mPlayer.Ctlcontrols.stop();
                pictureBox_Play.Visible = true;
                pictureBox_Pause.Visible = false;
            }
            pic_play.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_play.ImageLocation = dr[k]["Anh"].ToString();
            label_name.Text = dr[k]["TenBaiHat"].ToString();
            label_singer.Text = dr[k]["CaSi"].ToString();
            lbl_nghe.Text = dr[k]["LuotNghe"].ToString();
            richTextBox1.Text = File.ReadAllText(dr[k]["LoiBH"].ToString());
            if (check(label_name.Text) == 1)
            {
                pictureBox_unlove.Visible = true;
                pictureBox_love.Visible = false;
            }
            else
            {
                pictureBox_unlove.Visible = false;
                pictureBox_love.Visible = true;
            }
            hopeTrackBar1.Value = 0;
            flowLayoutPanel1.Controls.Clear();
            int location = 0;
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Image img2 = Image.FromFile(Path.Combine(executableLocation, "icon\\playlist.png"));
            Image img1 = Image.FromFile(Path.Combine(executableLocation, "icon\\play.png"));
            Image img3 = Image.FromFile(Path.Combine(executableLocation, "icon\\dowload.png"));
            for (int i = 0; i < dr.Length; i++)
            {
                Panel p = new Panel();
                p.Name = i.ToString();
                p.BackColor = Color.FromArgb(123, 123, 124);
                p.Size = new Size(flowLayoutPanel1.ClientSize.Width, 60);

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
                pic0.ImageLocation = dr[i]["Anh"].ToString();
                pic0.SizeMode = PictureBoxSizeMode.StretchImage;


                Label lb_name = new Label();
                p.Controls.Add(lb_name);
                lb_name.Name = "Name" + i.ToString();
                lb_name.Text = dr[i]["TenBaiHat"].ToString();
                lb_name.Width = 300;
                lb_name.Height = 20;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 5;
                lb_name.Left = 55;
                lb_name.Font = new Font("Times new roman", 13);

                Label lb_singer = new Label();
                p.Controls.Add(lb_singer);
                lb_name.Name = "Casi" + i.ToString();
                lb_singer.Text = dr[i]["CaSi"].ToString();
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
                pic2.Name = "list" + i.ToString();
                pic2.Width = 40;
                pic2.Height = 40;
                pic2.BackColor = Color.Transparent;
                pic2.Top = 10;
                pic2.Left = 405;
                pic2.Image = img2;
                pic2.SizeMode = PictureBoxSizeMode.StretchImage;
                pic2.Click += playlist_click;

                PictureBox pic3 = new PictureBox();
                p.Controls.Add(pic3);
                pic3.Name = "download" + i.ToString();
                pic3.Width = 40;
                pic3.Height = 40;
                pic3.BackColor = Color.Transparent;
                pic3.Top = 10;
                pic3.Left = 450;
                pic3.Image = img3;
                pic3.SizeMode = PictureBoxSizeMode.StretchImage;
                pic3.Click += download_click;


                flowLayoutPanel1.Controls.Add(p);
                flowLayoutPanel1.Controls.SetChildIndex(p, location);  // this moves the new one to the top!
                location += 60;                                         // this is just for fun                                                            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font,Size = 14, Brushes.White, 2, 12); };
                flowLayoutPanel1.Invalidate();
            }
        }

    }
}
