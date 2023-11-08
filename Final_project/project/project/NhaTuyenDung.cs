using NuGet.Protocol.Plugins;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using Panel = System.Windows.Forms.Panel;

namespace project
{
    public partial class NhaTuyenDung : Form
    {
        public NhaTuyenDung()
        {
            InitializeComponent();
        }
        DataRow[] drr;
        private void Tuyendung_Load(object sender, EventArgs e)
        {
            this.Text = "Quản lý nhà tuyển dụng";
            bt_Chao.Text = bt_Chao.Text + "\n" + DangNhap.ten;

            //dataGridView1.DataSource = DataJobs;
            load();
            load2(-1);
        }
        public static int flag = 0;
        void load()
        {
            drr = DangNhap.DataJob.Select("TenCongTy = '" + DangNhap.ten + "'");
            DataRow[] dd = DangNhap.DataComp.Select("TenCongTy = '" + DangNhap.ten + "'");


            string targetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            targetPath += "/Logo/";
            targetPath += dd[0]["Logo"].ToString();
            hopePictureBox1.ImageLocation = targetPath;
            flowLayoutPanel1.Controls.Clear();
            int location = 0;
            for (int i = 0; i < drr.Length; i++)
            {

                Panel p = new Panel();
                p.Name = i.ToString();
                p.BackColor = Color.LightSteelBlue;
                p.Size = new Size(670, 105);

                Label lb_name = new Label();
                p.Controls.Add(lb_name);
                lb_name.Name = "Name" + i.ToString();
                lb_name.Text = drr[i]["TenCongViec"].ToString();
                lb_name.Width = 485;
                lb_name.Height = 55;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 14;
                lb_name.Left = 16;
                lb_name.AllowDrop = true;
                lb_name.Font = new Font("Segoe UI", 15);
                lb_name.ForeColor = Color.Blue;

                Label lb_mluong = new Label();
                p.Controls.Add(lb_mluong);
                lb_mluong.Name = "mLuong" + i.ToString();
                lb_mluong.Text = "Mức lương: ";
                lb_mluong.Width = 120;
                lb_mluong.Height = 25;
                lb_mluong.BackColor = Color.Transparent;
                lb_mluong.Top = 70;
                lb_mluong.Left = 14;
                lb_mluong.AllowDrop = true;
                lb_mluong.Font = new Font("Segoe UI", 13);
                lb_mluong.ForeColor = Color.Black;

                Label lb_luong = new Label();
                p.Controls.Add(lb_luong);
                lb_luong.Name = "Luong" + i.ToString();
                lb_luong.Text = drr[i]["MucLuong"].ToString();
                lb_luong.Width = 360;
                lb_luong.Height = 25;
                lb_luong.BackColor = Color.Transparent;
                lb_luong.Top = 70;
                lb_luong.Left = 140;
                lb_luong.AllowDrop = true;
                lb_luong.Font = new Font("Segoe UI", 13);
                lb_luong.ForeColor = Color.Red;

                System.Windows.Forms.Button btn_sua = new System.Windows.Forms.Button();
                p.Controls.Add(btn_sua);
                btn_sua.Name = "Sua " + i.ToString();
                btn_sua.Text = "Chỉnh sửa";
                btn_sua.Width = 110;
                btn_sua.Height = 35;
                btn_sua.BackColor = Color.White;
                btn_sua.Top = 55;
                btn_sua.Left = 530;
                btn_sua.Font = new Font("Segoe UI", 13);
                btn_sua.Click += btn_sua_click;

                System.Windows.Forms.Button btn_xoa = new System.Windows.Forms.Button();
                p.Controls.Add(btn_xoa);
                btn_xoa.Name = "Xoa" + i.ToString();
                btn_xoa.Text = "Xoá";
                btn_xoa.Width = 110;
                btn_xoa.Height = 35;
                btn_xoa.BackColor = Color.White;
                btn_xoa.Top = 10;
                btn_xoa.Left = 530;
                btn_xoa.Font = new Font("Segoe UI", 13);
                btn_xoa.Click += btn_xoa_click;


                flowLayoutPanel1.Controls.Add(p);
                p.Click += panel_Click;
                flowLayoutPanel1.Controls.SetChildIndex(p, location);  // this moves the new one to the top!
                location += 105;                                         // this is just for fun                                                            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font,Size = 14, Brushes.White, 2, 12); };
                flowLayoutPanel1.Invalidate();
            }
        }


        void panel_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            string s = p.Name;
            int i = Int32.Parse(s);
            load2(i);
        }


        int n = 0;
        void btn_xoa_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button lb = (System.Windows.Forms.Button)sender;
            string s = lb.Name;
            n = Int32.Parse(s.Substring(3));
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelApp.Application excelApp = new ExcelApp.Application();
            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }
            string DataCompanyLocation = Path.Combine(executableLocation, "Congviec_data.xlsx");
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataCompanyLocation);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            int k = 0;
            int r = excelRange.Rows.Count;
            for (int i = 2; i <= r; i++)
            {
                if (excelRange.Cells[i, 13].Value2.ToString() == drr[n]["TenCongTy"].ToString()
                    && excelRange.Cells[i, 1].Value2.ToString() == drr[n]["TenCongViec"].ToString())
                    k = i;
            }
            ExcelApp.Range range = excelSheet.Rows[k];
            range.Delete();
            //MessageBox.Show(k.ToString());
            //for (int i = k; i < r; i++)
            //{
            //    excelRange.Cells[i, 1].Value2 = excelRange.Cells[i + 1, 1].Value2;
            //    excelRange.Cells[i, 2].Value2 = excelRange.Cells[i + 1, 2].Value2;
            //    excelRange.Cells[i, 3].Value2 = excelRange.Cells[i + 1, 3].Value2;
            //    excelRange.Cells[i, 4].Value2 = excelRange.Cells[i + 1, 4].Value2;
            //    excelRange.Cells[i, 5].Value2 = excelRange.Cells[i + 1, 5].Value2;
            //    excelRange.Cells[i, 6].Value2 = excelRange.Cells[i + 1, 6].Value2;
            //    excelRange.Cells[i, 7].Value2 = excelRange.Cells[i + 1, 7].Value2;
            //    excelRange.Cells[i, 8].Value2 = excelRange.Cells[i + 1, 8].Value2;
            //    excelRange.Cells[i, 9].Value2 = excelRange.Cells[i + 1, 9].Value2;
            //    excelRange.Cells[i, 10].Value2 = excelRange.Cells[i + 1, 10].Value2;
            //    excelRange.Cells[i, 11].Value2 = excelRange.Cells[i + 1, 11].Value2;
            //    excelRange.Cells[i, 12].Value2 = excelRange.Cells[i + 1, 12].Value2;
            //    excelRange.Cells[i, 13].Value2 = excelRange.Cells[i + 1, 13].Value2;
            //}

            //excelRange.Cells[r, 1].Value2 = "";
            //excelRange.Cells[r, 2].Value2 = "";
            //excelRange.Cells[r, 3].Value2 = "";
            //excelRange.Cells[r, 4].Value2 = "";
            //excelRange.Cells[r, 5].Value2 = "";
            //excelRange.Cells[r, 6].Value2 = "";
            //excelRange.Cells[r, 7].Value2 = "";
            //excelRange.Cells[r, 8].Value2 = "";
            //excelRange.Cells[r, 9].Value2 = "";
            //excelRange.Cells[r, 10].Value2 = "";
            //excelRange.Cells[r, 11].Value2 = "";
            //excelRange.Cells[r, 12].Value2 = "";
            //excelRange.Cells[r, 13].Value2 = "";

            excelApp.Visible = false;
            excelApp.UserControl = false;
            excelBook.Save();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(excelRange);
            Marshal.ReleaseComObject(excelSheet);

            excelBook.Close(Type.Missing, Type.Missing, Type.Missing);
            Marshal.ReleaseComObject(excelBook);

            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
            MessageBox.Show("Đã xoá thành công");
            xoa_apply();

            DataRow[] d = DangNhap.DataJob.Select("TenCongTy ='" + drr[n]["TenCongTy"].ToString() + "' AND TenCongViec ='" + drr[n]["TenCongViec"].ToString() + "'");
            for (int i = 0; i < d.Length; i++)
                d[i].Delete();
            DangNhap.DataJob.AcceptChanges();

            load();
            load2(-1);
        }

        void xoa_apply()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelApp.Application excelApp = new ExcelApp.Application();
            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }
            string DataCompanyLocation = Path.Combine(executableLocation, "Apply.xlsx");
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataCompanyLocation);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            int k = 0;
            int r = excelRange.Rows.Count;
            for (int i = 2; i <= r; i++)
            {
                if (excelRange.Cells[i, 1].Value2.ToString() == drr[n]["TenCongTy"].ToString()
                    && excelRange.Cells[i, 2].Value2.ToString() == drr[n]["TenCongViec"].ToString())
                    k = i;
            }
            ExcelApp.Range range = excelSheet.Rows[k];
            range.Delete();

            excelApp.Visible = false;
            excelApp.UserControl = false;
            excelBook.Save();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(excelRange);
            Marshal.ReleaseComObject(excelSheet);

            excelBook.Close(Type.Missing, Type.Missing, Type.Missing);
            Marshal.ReleaseComObject(excelBook);

            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }

        void load2(int k)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenCongTy", typeof(string));
            dt.Columns.Add("TenCongViec", typeof(string));
            dt.Columns.Add("TenUngVien", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("ThoiGian", typeof(string));
            dt.Columns.Add("CV", typeof(string));

            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelApp.Application excelApp = new ExcelApp.Application();
            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }
            string DataCompanyLocation = Path.Combine(executableLocation, "Apply.xlsx");
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataCompanyLocation);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            DataRow row;
            int r = excelRange.Rows.Count;
            for (int i = 2; i <= r; i++)  // <= CountRowsJobs
            {
                row = dt.NewRow();
                row["TenCongTy"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                row["TenCongViec"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                row["TenUngVien"] = excelRange.Cells[i, 3].Value2.ToString(); //string
                row["Email"] = excelRange.Cells[i, 4].Value2.ToString(); //string
                row["ThoiGian"] = excelRange.Cells[i, 5].Value2.ToString(); //string
                row["CV"] = excelRange.Cells[i, 6].Value2.ToString(); //string

                dt.Rows.Add(row);
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


            DataRow[] dr;
            if (k == -1)
                dr = dt.Select("TenCongTy = '" + DangNhap.ten + "'");
            else
            {
                string s = drr[k]["TenCongViec"].ToString();
                dr = dt.Select("TenCongTy = '" + DangNhap.ten + "' AND TenCongViec = '" + s + "'");
            }

            flowLayoutPanel2.Controls.Clear();
            int location = 0;
            for (int i = 0; i < dr.Length; i++)
            {

                Panel p = new Panel();
                p.Name = i.ToString();
                p.BackColor = Color.LightSteelBlue;
                p.Size = new Size(450, 145);

                Label lb_name = new Label();
                p.Controls.Add(lb_name);
                lb_name.Name = "TenCongViec" + i.ToString();
                lb_name.Text = dr[i]["TenCongViec"].ToString();
                lb_name.Width = 415;
                lb_name.Height = 30;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 10;
                lb_name.Left = 15;
                lb_name.AutoEllipsis = true;
                lb_name.Font = new Font("Segoe UI", 13);
                lb_name.ForeColor = Color.Blue;

                Label lb_tenungvien = new Label();
                p.Controls.Add(lb_tenungvien);
                lb_tenungvien.Name = "Ungvien" + i.ToString();
                lb_tenungvien.Text = "Họ tên: " + dr[i]["TenUngVien"].ToString();
                lb_tenungvien.Width = 415;
                lb_tenungvien.Height = 30;
                lb_tenungvien.BackColor = Color.Transparent;
                lb_tenungvien.Top = 45;
                lb_tenungvien.Left = 15;
                lb_tenungvien.AllowDrop = true;
                lb_tenungvien.Font = new Font("Segoe UI", 13);
                lb_tenungvien.ForeColor = Color.Black;

                Label lb_thoigian = new Label();
                p.Controls.Add(lb_thoigian);
                lb_thoigian.Name = "TG" + i.ToString();
                lb_thoigian.Text = "Thời gian: " + dr[i]["ThoiGian"].ToString();
                lb_thoigian.Width = 415;
                lb_thoigian.Height = 30;
                lb_thoigian.BackColor = Color.Transparent;
                lb_thoigian.Top = 80;
                lb_thoigian.Left = 15;
                lb_thoigian.AllowDrop = true;
                lb_thoigian.Font = new Font("Segoe UI", 13);
                lb_thoigian.ForeColor = Color.Black;


                Label lb = new Label();
                p.Controls.Add(lb);
                lb.Name = "a" + i.ToString();
                lb.Text = "CV: ";
                lb.Width = 80;
                lb.Height = 30;
                lb.BackColor = Color.Transparent;
                lb.Top = 115;
                lb.Left = 15;
                lb.AllowDrop = true;
                lb.Font = new Font("Segoe UI", 13);
                lb.ForeColor = Color.Black;

                LinkLabel lb_cv = new LinkLabel();
                p.Controls.Add(lb_cv);
                lb_cv.Name = "CV" + i.ToString();
                lb_cv.Text = dr[i]["CV"].ToString();
                lb_cv.Width = 300;
                lb_cv.Height = 30;
                lb_cv.BackColor = Color.Transparent;
                lb_cv.Top = 115;
                lb_cv.Left = 100;
                lb_cv.AllowDrop = true;
                lb_cv.Font = new Font("Segoe UI", 13);
                lb_cv.ForeColor = Color.Red;
                lb_cv.Click += link_lb_click;

                flowLayoutPanel2.Controls.Add(p);
                //p.Click += panel_click;
                flowLayoutPanel2.Controls.SetChildIndex(p, location);  // this moves the new one to the top!
                location += 145;                                         // this is just for fun                                                            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font,Size = 14, Brushes.White, 2, 12); };
                flowLayoutPanel2.Invalidate();
            }


        }
        public static string cv = "";
        void link_lb_click(object sender, EventArgs e)
        {
            LinkLabel lb = (LinkLabel)sender;
            cv = lb.Text;
            CVUngVien fcv = new CVUngVien();
            this.Hide();
            fcv.ShowDialog();
            this.Show();
        }
        void btn_xoa_click()
        {

        }
        public static DataRow drr1;
        void btn_sua_click(object sender, EventArgs e)
        {
            flag = 1;
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string s = button.Name;
            int i = Int32.Parse(s.Substring(4));
            drr1 = drr[i];
            DangCongViec dangcv = new DangCongViec();
            this.Hide();
            dangcv.ShowDialog();
            this.Show();
            load();
            load2(-1);
        }
        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NhaTuyenDung.flag = 0;
            DangCongViec dangcv = new DangCongViec();
            this.Hide();
            dangcv.ShowDialog();
            this.Show();
            load();
            load2(-1);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        public static int f_close_td = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.ShowDialog();
            if (f_close_td == 0)
                this.Show();
            else
                this.Close();
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            load2(-1);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
