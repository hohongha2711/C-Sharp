using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public static DataTable DataJobs = new DataTable();
        public static DataTable DataCompany = new DataTable();
        public static DataRow[] dr;
        int cur = 0;
        public static int fl_ap = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Danh sách các công việc";
            bt_Chao.Text = bt_Chao.Text + "\n" + DangNhap.ten;
            DataJobs = DangNhap.DataJob;
            DataCompany = DangNhap.DataComp;
            dr = DataJobs.Select();
            load(cur);
        }

        void import_Congviec()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataJobsLocation = Path.Combine(executableLocation, "Congviec_data.xlsx");

            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();
            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataJobsLocation);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;


            DataRow row;

            //first row using for heading, start second row for data
            for (int i = 2; i <= 1400; i++)  // <= CountRowsJobs
            {
                row = DataJobs.NewRow();
                row["TenCongViec"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                row["CongTy"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                row["DiaChi"] = excelRange.Cells[i, 3].Value2.ToString(); //string
                row["MucLuong"] = excelRange.Cells[i, 4].Value2.ToString(); //string
                row["MoTa"] = excelRange.Cells[i, 5].Value2.ToString(); //string
                row["YeuCau"] = excelRange.Cells[i, 6].Value2.ToString(); //string
                row["TenLienHe"] = excelRange.Cells[i, 7].Value2.ToString(); //string
                row["SDT"] = excelRange.Cells[i, 8].Value2.ToString(); //string
                row["Mail"] = excelRange.Cells[i, 9].Value2.ToString(); //string
                row["DiaChiLienHe"] = excelRange.Cells[i, 10].Value2.ToString(); //string
                row["Note"] = excelRange.Cells[i, 11].Value2.ToString(); //string
                row["LinhVuc"] = excelRange.Cells[i, 12].Value2.ToString(); //string

                DataJobs.Rows.Add(row);
            }
            excelApp.Visible = false;
            excelApp.UserControl = false;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(excelRange);
            Marshal.ReleaseComObject(excelSheet);

            excelBook.Close(Type.Missing, Type.Missing, Type.Missing);
            Marshal.ReleaseComObject(excelBook);

            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);


        }

        void import_congty()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelApp.Application excelApp = new ExcelApp.Application();
            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }
            string DataCompanyLocation = Path.Combine(executableLocation, "congty.xlsx");
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataCompanyLocation);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            DataRow row;

            for (int i = 2; i <= 385; i++)  // <= CountRowsJobs
            {
                row = DataCompany.NewRow();
                row["STT"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                row["TenCongTy"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                row["DiaChi"] = excelRange.Cells[i, 3].Value2.ToString(); //string
                row["SoNV"] = excelRange.Cells[i, 4].Value2.ToString(); //string
                row["MoTa"] = excelRange.Cells[i, 5].Value2.ToString(); //string
                row["Logo"] = excelRange.Cells[i, 6].Value2.ToString(); //string

                DataCompany.Rows.Add(row);
            }
            excelApp.Visible = false;
            excelApp.UserControl = false;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(excelRange);
            Marshal.ReleaseComObject(excelSheet);

            excelBook.Close(Type.Missing, Type.Missing, Type.Missing);
            Marshal.ReleaseComObject(excelBook);

            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);

        }
        void load(int cur)
        {
            bigLabel1.Text = "Có " + dr.Length.ToString() + " việc làm dành cho bạn";
            if (cur == 0)
            {
                btn_pre.Visible = false;
            }

            else
                btn_pre.Visible = true;

            flowLayoutPanel1.Controls.Clear();
            int location = 0;
            int k = cur + 50;
            if (k > dr.Length)
            {
                k = dr.Length;
                btn_next.Visible = false;
                cur = 0;
            }
            else
                btn_next.Visible = true;

            for (int i = cur; i < k; i++)
            {
                string tenct = dr[i]["CongTy"].ToString();
                DataRow[] d = DataCompany.Select("STT = '" + tenct + "'");
                Panel p = new Panel();
                p.Name = i.ToString();
                p.BackColor = Color.LightSteelBlue;
                p.Size = new Size(flowLayoutPanel1.ClientSize.Width, 170);

                //Image img0 = Image."https://avatar-ex-swe.nixcdn.com/song/2022/10/16/5/e/5/8/1665899566109.jpg";
                //Image img0 = Image.FromFile("https://avatar-ex-swe.nixcdn.com/song/2022/10/16/5/e/5/8/1665899566109.jpg");
                //Image im = Image.U
                //p.Controls.Add(pic1);
                //PictureBox[] pipe = new PictureBox[2];
                string targetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                targetPath += "/Logo/";
                targetPath += d[0]["Logo"].ToString();
                PictureBox pic0 = new PictureBox();
                p.Controls.Add(pic0);
                pic0.Name = "picture" + i.ToString();
                pic0.Width = 130;
                pic0.Height = 130;
                pic0.BackColor = Color.Transparent;
                pic0.Top = 20;
                pic0.Left = 10;
                pic0.ImageLocation =targetPath;
                pic0.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lb_name = new Label();
                p.Controls.Add(lb_name);
                lb_name.Name = "Name" + i.ToString();
                lb_name.Text = dr[i]["TenCongViec"].ToString();
                lb_name.Width = 600;
                lb_name.Height = 60;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 15;
                lb_name.Left = 145;
                lb_name.AllowDrop = true;
                lb_name.Font = new Font("Segoe UI", 16);
                lb_name.ForeColor = Color.Blue;


                Label lb_congty = new Label();
                p.Controls.Add(lb_congty);
                lb_congty.Name = "Congty" + i.ToString();
                lb_congty.Text = d[0]["TenCongTy"].ToString();
                lb_congty.Width = 600;
                lb_congty.Height = 60;
                lb_congty.BackColor = Color.Transparent;
                lb_congty.Top = 75;
                lb_congty.Left = 145;
                lb_congty.AllowDrop = true;
                lb_congty.Font = new Font("Segoe UI", 13);
                lb_congty.ForeColor = Color.Navy;

                Label lb_mluong = new Label();
                p.Controls.Add(lb_mluong);
                lb_mluong.Name = "mLuong" + i.ToString();
                lb_mluong.Text = "Mức lương: ";
                lb_mluong.Width = 105;
                lb_mluong.Height = 25;
                lb_mluong.BackColor = Color.Transparent;
                lb_mluong.Top = 137;
                lb_mluong.Left = 145;
                lb_mluong.AllowDrop = true;
                lb_mluong.Font = new Font("Segoe UI", 13);
                lb_mluong.ForeColor = Color.Black;

                Label lb_luong = new Label();
                p.Controls.Add(lb_luong);
                lb_luong.Name = "Luong" + i.ToString();
                lb_luong.Text = dr[i]["MucLuong"].ToString();
                lb_luong.Width = 300;
                lb_luong.Height = 25;
                lb_luong.BackColor = Color.Transparent;
                lb_luong.Top = 137;
                lb_luong.Left = 250;
                lb_luong.AllowDrop = true;
                lb_luong.Font = new Font("Segoe UI", 13);
                lb_luong.ForeColor = Color.Red;

                Label lb_diachi = new Label();
                p.Controls.Add(lb_diachi);
                lb_diachi.Name = "Diachi" + i.ToString();
                lb_diachi.Text = dr[i]["DiaChi"].ToString();
                lb_diachi.Width = 295;
                lb_diachi.Height = 60;
                lb_diachi.BackColor = Color.Transparent;
                lb_diachi.Top = 77;
                lb_diachi.Left = 745;
                lb_diachi.AllowDrop = true;
                lb_diachi.Font = new Font("Segoe UI", 13);
                lb_diachi.ForeColor = Color.Black;

                Label lv_linhvuc = new Label();
                p.Controls.Add(lv_linhvuc);
                lv_linhvuc.Name = "LV" + i.ToString();
                lv_linhvuc.Text = "Lĩnh vực: " + dr[i]["LinhVuc"].ToString();
                lv_linhvuc.Width = 295;
                lv_linhvuc.Height = 30;
                lv_linhvuc.BackColor = Color.Transparent;
                lv_linhvuc.Top = 137;
                lv_linhvuc.Left = 745;
                lv_linhvuc.AllowDrop = true;
                lv_linhvuc.Font = new Font("Segoe UI", 13);
                lv_linhvuc.ForeColor = Color.Black;


                flowLayoutPanel1.Controls.Add(p);
                p.Click += panel_click;
                flowLayoutPanel1.Controls.SetChildIndex(p, location);  // this moves the new one to the top!
                location += 175;                                         // this is just for fun                                                            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font,Size = 14, Brushes.White, 2, 12); };
                flowLayoutPanel1.Invalidate();
            }
        }
        public static int curent = -1;
        void panel_click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            int i = Int32.Parse(p.Name);

            curent = i;
            CongViec dangcv = new CongViec();
            this.Hide();
            dangcv.ShowDialog();
            this.Show();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            cur += 50;
            load(cur);
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            cur -= 50;
            load(cur);
        }

        private void lb_Ten_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        string lv = "";
        private void search(string s, string s1)

        {
            dr = DataJobs.Select("TenCongViec like '%" + s + "%' OR TenCongTy like '%" + s + "%' OR MucLuong like '%" + s + "%' OR LinhVuc like '%" + s + "%'");

            DataTable data = dr.CopyToDataTable();

            if (s1 == "")
                dr = data.Select();
            else if (s1 == "All")
                dr = data.Select();
            else
                dr = data.Select("DiaChi like '%" + s1 + "%'");
            cur = 0;
            load(cur);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search(txt_timkiem.Text, lv);
        }
        public static int close_f_uv = 0;
        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
            if(DangNhap.fl_nhatuyendung == 0)
            {
                NguoiUngTuyen ut = new NguoiUngTuyen();
                this.Hide();
                ut.ShowDialog();
                if (close_f_uv == 0)
                    this.Show();
                else
                    this.Close();
            }    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(DangNhap.fl_nhatuyendung == 1)
            {
                NhaTuyenDung.f_close_td = 1;
                this.Close();
            }    
            this.Close();
        }

        private void khuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
                dr = DataJobs.Select("TenCongViec like '%" + txt_timkiem.Text + "%' OR TenCongTy like '%" + txt_timkiem.Text + "%' OR MucLuong like '%" + txt_timkiem.Text + "%' OR LinhVuc like '%" + txt_timkiem.Text + "%'");
            else
                dr = DataJobs.Select();
            lv = khuvuc.Text;
            DataTable data = dr.CopyToDataTable();

            if (lv == "")
                dr = data.Select();
            else if (lv == "All")
                dr = data.Select();
            else
                dr = data.Select("DiaChi like '%" + lv + "%'");
            cur = 0;
            load(cur);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
            khuvuc.Text = "All";
            dr = DataJobs.Select();
            cur = 0;
            load(cur);
        }
    }
}
