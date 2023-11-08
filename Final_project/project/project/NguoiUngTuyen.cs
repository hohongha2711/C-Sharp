using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using Panel = System.Windows.Forms.Panel;

namespace project
{
    public partial class NguoiUngTuyen : Form
    {
        public NguoiUngTuyen()
        {
            InitializeComponent();
        }

        private void NguoiUngTuyen_Load(object sender, EventArgs e)
        {
            Main.close_f_uv = 0;
            this.Text = "Quản lý người tìm việc";
            bt_Chao.Text = bt_Chao.Text + "\n" + DangNhap.ten;
            load1();
            load2();
        }


        void load2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenCongTy", typeof(string));
            dt.Columns.Add("TenCongViec", typeof(string));
            dt.Columns.Add("TenUngVien", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("ThoiGian", typeof(string));
            dt.Columns.Add("CV", typeof(string));
            dt.Columns.Add("User", typeof(string));

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
                row["User"] = excelRange.Cells[i, 7].Value2.ToString(); //string

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


            DataRow[] drr = dt.Select("User ='" + DangNhap.tendangnhap + "'");


            flowLayoutPanel2.Controls.Clear();
            int location = 0;
            for (int i = 0; i < drr.Length; i++)
            {

                Panel p = new Panel();
                p.Name = i.ToString();
                p.BackColor = Color.LightSteelBlue;
                p.Size = new Size(450, 115);

                Label lb_name = new Label();
                p.Controls.Add(lb_name);
                lb_name.Name = "TenCongViec" + i.ToString();
                lb_name.Text = drr[i]["TenCongViec"].ToString();
                lb_name.Width = 415;
                lb_name.Height = 30;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 10;
                lb_name.Left = 15;
                lb_name.AutoEllipsis = true;
                lb_name.Font = new Font("Segoe UI", 13);
                lb_name.ForeColor = Color.Blue;

                Label lb_tencongty = new Label();
                p.Controls.Add(lb_tencongty);
                lb_tencongty.Name = "Ungvien" + i.ToString();
                lb_tencongty.Text = "Công ty: " + drr[i]["TenCongTy"].ToString();
                lb_tencongty.Width = 415;
                lb_tencongty.Height = 30;
                lb_tencongty.BackColor = Color.Transparent;
                lb_tencongty.Top = 45;
                lb_tencongty.Left = 15;
                lb_tencongty.AllowDrop = true;
                lb_tencongty.Font = new Font("Segoe UI", 13);
                lb_tencongty.ForeColor = Color.Black;

                Label lb_thoigian = new Label();
                p.Controls.Add(lb_thoigian);
                lb_thoigian.Name = "TG" + i.ToString();
                lb_thoigian.Text = "Thời gian: " + drr[i]["ThoiGian"].ToString();
                lb_thoigian.Width = 415;
                lb_thoigian.Height = 30;
                lb_thoigian.BackColor = Color.Transparent;
                lb_thoigian.Top = 80;
                lb_thoigian.Left = 15;
                lb_thoigian.AllowDrop = true;
                lb_thoigian.Font = new Font("Segoe UI", 13);
                lb_thoigian.ForeColor = Color.Black;


                flowLayoutPanel2.Controls.Add(p);
                //p.Click += panel_click;
                flowLayoutPanel2.Controls.SetChildIndex(p, location);  // this moves the new one to the top!
                location += 115;                                         // this is just for fun                                                            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font,Size = 14, Brushes.White, 2, 12); };
                flowLayoutPanel2.Invalidate();
            }
        }
        public static DataRow[] dr;
        void load1()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("User", typeof(string));
            dt.Columns.Add("TenCongViec", typeof(string));
            dt.Columns.Add("TenCongTy", typeof(string));
            dt.Columns.Add("MucLuong", typeof(string));

            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelApp.Application excelApp = new ExcelApp.Application();
            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }
            string DataCompanyLocation = Path.Combine(executableLocation, "Save.xlsx");
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataCompanyLocation);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            DataRow row;
            int r = excelRange.Rows.Count;
            for (int i = 2; i <= r; i++)  // <= CountRowsJobs
            {
                row = dt.NewRow();
                row["User"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                row["TenCongViec"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                row["TenCongTy"] = excelRange.Cells[i, 3].Value2.ToString(); //string
                row["MucLuong"] = excelRange.Cells[i, 4].Value2.ToString(); //string

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


            dr = dt.Select("User ='" + DangNhap.tendangnhap + "'");

            flowLayoutPanel1.Controls.Clear();
            int location = 0;
            for (int i = 0; i < dr.Length; i++)
            {

                Panel p = new Panel();
                p.Name = i.ToString();
                p.BackColor = Color.LightSteelBlue;
                p.Size = new Size(670, 180);

                Label lb_name = new Label();
                p.Controls.Add(lb_name);
                lb_name.Name = "Name" + i.ToString();
                lb_name.Text = dr[i]["TenCongViec"].ToString();
                lb_name.Width = 485;
                lb_name.Height = 55;
                lb_name.BackColor = Color.Transparent;
                lb_name.Top = 14;
                lb_name.Left = 16;
                lb_name.AllowDrop = true;
                lb_name.Font = new Font("Segoe UI", 15);
                lb_name.ForeColor = Color.Blue;

                Label lb_namect = new Label();
                p.Controls.Add(lb_namect);
                lb_namect.Name = "Name" + i.ToString();
                lb_namect.Text = dr[i]["TenCongTy"].ToString();
                lb_namect.Width = 485;
                lb_namect.Height = 55;
                lb_namect.BackColor = Color.Transparent;
                lb_namect.Top = 75;
                lb_namect.Left = 16;
                lb_namect.AllowDrop = true;
                lb_namect.Font = new Font("Segoe UI", 15);
                lb_namect.ForeColor = Color.Navy;

                Label lb_mluong = new Label();
                p.Controls.Add(lb_mluong);
                lb_mluong.Name = "mLuong" + i.ToString();
                lb_mluong.Text = "Mức lương: ";
                lb_mluong.Width = 120;
                lb_mluong.Height = 25;
                lb_mluong.BackColor = Color.Transparent;
                lb_mluong.Top = 145;
                lb_mluong.Left = 14;
                lb_mluong.AllowDrop = true;
                lb_mluong.Font = new Font("Segoe UI", 13);
                lb_mluong.ForeColor = Color.Black;

                Label lb_luong = new Label();
                p.Controls.Add(lb_luong);
                lb_luong.Name = "Luong" + i.ToString();
                lb_luong.Text = dr[i]["MucLuong"].ToString();
                lb_luong.Width = 400;
                lb_luong.Height = 25;
                lb_luong.BackColor = Color.Transparent;
                lb_luong.Top = 145;
                lb_luong.Left = 140;
                lb_luong.AllowDrop = true;
                lb_luong.Font = new Font("Segoe UI", 13);
                lb_luong.ForeColor = Color.Red;

                System.Windows.Forms.Button btn_apply = new System.Windows.Forms.Button();
                p.Controls.Add(btn_apply);
                btn_apply.Name = "Apply" + i.ToString();
                btn_apply.Text = "Apply";
                btn_apply.Width = 110;
                btn_apply.Height = 35;
                btn_apply.BackColor = Color.White;
                btn_apply.Top = 30;
                btn_apply.Left = 530;
                btn_apply.Font = new Font("Segoe UI", 13);
                btn_apply.Click += btn_apply_click;

                System.Windows.Forms.Button btn_xoa = new System.Windows.Forms.Button();
                p.Controls.Add(btn_xoa);
                btn_xoa.Name = "Xoa" + i.ToString();
                btn_xoa.Text = "Xoá";
                btn_xoa.Width = 110;
                btn_xoa.Height = 35;
                btn_xoa.BackColor = Color.White;
                btn_xoa.Top = 95;
                btn_xoa.Left = 530;
                btn_xoa.Font = new Font("Segoe UI", 13);
                btn_xoa.Click += btn_Xoa_click;



                flowLayoutPanel1.Controls.Add(p);
                //p.Click += panel_click;
                flowLayoutPanel1.Controls.SetChildIndex(p, location);  // this moves the new one to the top!
                location += 180;                                         // this is just for fun                                                            //p.Paint += (ss, ee) => { ee.Graphics.DrawString(p.Name, Font,Size = 14, Brushes.White, 2, 12); };
                flowLayoutPanel1.Invalidate();
            }
        }

        void btn_Xoa_click(object sender, EventArgs e)
        {
            Button lb = (Button)sender;
            string s = lb.Name;
            int n = Int32.Parse(s.Substring(3));
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelApp.Application excelApp = new ExcelApp.Application();
            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }
            string DataCompanyLocation = Path.Combine(executableLocation, "Save.xlsx");
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataCompanyLocation);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            int k = 0;
            int r = excelRange.Rows.Count;
            for (int i = 2; i <= r; i++) 
            {
                if (excelRange.Cells[i, 1].Value2.ToString() == DangNhap.tendangnhap &&
                     excelRange.Cells[i, 2].Value2.ToString() == dr[n]["TenCongViec"].ToString()
                     && excelRange.Cells[i, 3].Value2.ToString() == dr[n]["TenCongTy"].ToString())
                    k = i;
            }
            for (int i = k; i < r; i++) 
            {
                excelRange.Cells[i, 1].Value2 = excelRange.Cells[i + 1, 1].Value2;
                excelRange.Cells[i, 2].Value2 = excelRange.Cells[i + 1, 2].Value2;
                excelRange.Cells[i, 3].Value2 = excelRange.Cells[i + 1, 3].Value2;
                excelRange.Cells[i, 4].Value2 = excelRange.Cells[i + 1, 4].Value2;
            }

            excelRange.Cells[r, 1].Value2 = "";
            excelRange.Cells[r, 2].Value2 = "";
            excelRange.Cells[r, 3].Value2 = "";
            excelRange.Cells[r, 4].Value2 = "";

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
            load1();
        }

        public static int i = 0;
        void btn_apply_click(object sender, EventArgs e)
        {
            Button lb = (Button)sender;
            string s = lb.Name;
            i = Int32.Parse(s.Substring(5));
            Main.fl_ap = 1;
            Apply ap = new Apply();
            this.Hide();
            ap.ShowDialog();
            this.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main.close_f_uv = 1;
            this.Close();
        }
    }
}

