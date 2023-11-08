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

namespace project
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static DataTable DataJob = new DataTable();
        public static DataTable DataComp = new DataTable();
        public static DataTable DataAcc = new DataTable();
        public static DataTable Ungvien = new DataTable();
        public static DataRow[] dr_acc;
        public static string ten;
        public static string tendangnhap;
        public static int fl_nhatuyendung = 0;
        private void DangNhap_Load(object sender, EventArgs e)
        {
            fl_nhatuyendung = 0;
            DataJob.Columns.Add("TenCongViec", typeof(string));
            DataJob.Columns.Add("CongTy", typeof(string));
            DataJob.Columns.Add("DiaChi", typeof(string));
            DataJob.Columns.Add("MucLuong", typeof(string));
            DataJob.Columns.Add("MoTa", typeof(string));
            DataJob.Columns.Add("YeuCau", typeof(string));
            DataJob.Columns.Add("TenLienHe", typeof(string));
            DataJob.Columns.Add("SDT", typeof(string));
            DataJob.Columns.Add("Mail", typeof(string));
            DataJob.Columns.Add("DiaChiLienHe", typeof(string));
            DataJob.Columns.Add("Note", typeof(string));
            DataJob.Columns.Add("LinhVuc", typeof(string));
            DataJob.Columns.Add("TenCongTy", typeof(string));

            import_Congviec();

            DataComp.Columns.Add("STT", typeof(string));
            DataComp.Columns.Add("TenCongTy", typeof(string));
            DataComp.Columns.Add("DiaChi", typeof(string));
            DataComp.Columns.Add("SoNV", typeof(string));
            DataComp.Columns.Add("MoTa", typeof(string));
            DataComp.Columns.Add("Logo", typeof(string));

            import_congty();

            DataAcc.Columns.Add("TenDangNhap",typeof(string));  
            DataAcc.Columns.Add("MatKhau",typeof (string));
            DataAcc.Columns.Add("Ten", typeof(string));
            DataAcc.Columns.Add("LoaiTK", typeof(string));
            DataAcc.Columns.Add("Mail", typeof(string));

            import_account();

            Ungvien.Columns.Add("TaiKhoan", typeof(string));
            Ungvien.Columns.Add("HoTen", typeof(string));
            Ungvien.Columns.Add("Mail", typeof(string));
            Ungvien.Columns.Add("SDT", typeof(string));
            Ungvien.Columns.Add("NgaySinh", typeof(string));
            Ungvien.Columns.Add("DiaChi", typeof(string));
            Ungvien.Columns.Add("BangCap", typeof(string));

            import_ungvien();

        }

        void import_ungvien()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataJobsLocation = Path.Combine(executableLocation, "Ungvien.xlsx");

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

            int r = excelRange.Rows.Count;
            DataRow row;

            //first row using for heading, start second row for data
            for (int i = 2; i <= r; i++)  // <= CountRowsJobs
            {
                row = Ungvien.NewRow();
                row["TaiKhoan"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                row["HoTen"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                row["Mail"] = excelRange.Cells[i, 3].Value2.ToString(); //string
                row["SDT"] = excelRange.Cells[i, 4].Value2.ToString();
                row["NgaySinh"] = excelRange.Cells[i, 5].Value2.ToString(); //string
                row["DiaChi"] = excelRange.Cells[i, 6].Value2.ToString(); //string
                row["BangCap"] = excelRange.Cells[i, 7].Value2.ToString(); //string//string
                Ungvien.Rows.Add(row);
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
        public static int f_dk = 0;
        private void lb_taotk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_dk++;
            DangKy dk = new DangKy();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            fl_nhatuyendung = 0;
            if (quyen.Text == "Nhà tuyển dụng")
            {
                dr_acc = DataAcc.Select("TenDangNhap = '" + txt_tentk.Texts + "' AND MatKhau = '" + txt_mk.Texts + "' AND LoaiTK = '0'");
                if (dr_acc.Length > 0)
                {
                    fl_nhatuyendung = 1;
                    ten = dr_acc[0]["Ten"].ToString();
                    tendangnhap = txt_tentk.Texts;
                    NhaTuyenDung nha = new NhaTuyenDung();
                    this.Hide();
                    nha.ShowDialog();
                    this.Show();
                    txt_tentk.Texts = "";
                    txt_mk.Texts = "";
                    ten = "";
                    tendangnhap = "";
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }    
              
            else
            {
                dr_acc = DataAcc.Select("TenDangNhap = '" + txt_tentk.Texts + "' AND MatKhau = '" + txt_mk.Texts + "' AND LoaiTK = '1'");
                if (dr_acc.Length > 0)
                {
                    ten = dr_acc[0]["Ten"].ToString();
                    tendangnhap = txt_tentk.Texts;
                    Main main = new Main();
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                    txt_tentk.Texts = "";
                    txt_mk.Texts = "";
                    ten = "";
                    tendangnhap = "";
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }    
                       
        }

        void import_account()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataJobsLocation = Path.Combine(executableLocation, "account.xlsx");

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

            int r = excelRange.Rows.Count;
            DataRow row;

            //first row using for heading, start second row for data
            for (int i = 2; i <= r; i++)  // <= CountRowsJobs
            {
                row = DataAcc.NewRow();
                row["TenDangNhap"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                row["MatKhau"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                row["Ten"] = excelRange.Cells[i, 3].Value2.ToString(); //string
                row["LoaiTK"] = excelRange.Cells[i, 4].Value2.ToString();
                row["Mail"] = excelRange.Cells[i, 5].Value2.ToString();
                //string
                DataAcc.Rows.Add(row);
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

            int r = excelRange.Rows.Count;
            DataRow row;

            //first row using for heading, start second row for data
            for (int i = 2; i <= r; i++)  // <= CountRowsJobs
            {
                row = DataJob.NewRow();
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
                row["TenCongTy"] = excelRange.Cells[i, 13].Value2.ToString(); //string

                DataJob.Rows.Add(row);
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
            int r = excelRange.Rows.Count;
            for (int i = 2; i <= r; i++)  // <= CountRowsJobs
            {
                row = DataComp.NewRow();
                row["STT"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                row["TenCongTy"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                row["DiaChi"] = excelRange.Cells[i, 3].Value2.ToString(); //string
                row["SoNV"] = excelRange.Cells[i, 4].Value2.ToString(); //string
                row["MoTa"] = excelRange.Cells[i, 5].Value2.ToString(); //string
                row["Logo"] = excelRange.Cells[i, 6].Value2.ToString(); //string

                DataComp.Rows.Add(row);
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

        private void txt_mk_Click(object sender, EventArgs e)
        {

        }

        private void lb_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            this.Hide();
            dmk.ShowDialog();
            this.Show();
        }

        private void skyLabel3_Click(object sender, EventArgs e)
        {

        }

        private void picture_unhide_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox_hide_Click(object sender, EventArgs e)
        {

        }
    }
}
