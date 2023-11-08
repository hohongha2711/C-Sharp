using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace project
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        public static DataTable DataAccount = new DataTable();
        public static DataTable DataUngVien = new DataTable();

        string logo = "";

        bool check_mk(string s1, string s2)
        {
            if (s1 != s2)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return false;
            }
            return true;
        }
        private void btn_DkUV_Click(object sender, EventArgs e)
        {
            if (check_null2())
                if (check2())
                {
                    if (check_mk(txtMatKhau.Text, txtNhapLai.Text))
                    {
                        string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        string DataAcc = Path.Combine(executableLocation, "account.xlsx");

                        //Create COM Objects.
                        ExcelApp.Application excelApp = new ExcelApp.Application();
                        //Notice: Change this path to your real excel file path
                        ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAcc);
                        ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                        ExcelApp.Range excelRange = excelSheet.UsedRange;

                        int row = excelRange.Rows.Count;

                        excelApp.Cells[row + 1, 1].Value2 = txtTaiKhoan.Text;
                        excelApp.Cells[row + 1, 2].Value2 = txtMatKhau.Text;
                        excelApp.Cells[row + 1, 3].Value2 = txt_Name.Text;
                        excelApp.Cells[row + 1, 4].Value2 = "1";
                        excelApp.Cells[row + 1, 5].Value2 = txt_Mail.Text;

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


                        DataRow drow = DangNhap.DataAcc.NewRow();
                        drow["TenDangNhap"] = txtTaiKhoan.Text; //string
                        drow["MatKhau"] = txtMatKhau.Text; //string
                        drow["Ten"] = txt_Name.Text; //string
                        drow["LoaiTK"] = "1";
                        drow["Mail"] = txt_Mail.Text;
                        //string
                        DangNhap.DataAcc.Rows.Add(drow);

                        insert_data_uv();
                        insert_datauv();

                        EmailSendCV_UV();

                        MessageBox.Show("Tạo tài khoản ứng viên thành công.");

                        this.Close();
                    }
                }
        }

        void insert_data_uv()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataAccUV = Path.Combine(executableLocation, "Ungvien.xlsx");

            ExcelApp.Application excelApp = new ExcelApp.Application();
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAccUV);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            int row1 = excelRange.Rows.Count;

            excelApp.Cells[row1 + 1, 1].Value2 = txtTaiKhoan.Text;
            excelApp.Cells[row1 + 1, 2].Value2 = txt_Name.Text;
            excelApp.Cells[row1 + 1, 3].Value2 = txt_Mail.Text;
            excelApp.Cells[row1 + 1, 4].Value2 = txt_SDT.Text;
            excelApp.Cells[row1 + 1, 5].Value2 = NgaySinh.Value.ToString("dd/MM/yyyy");
            excelApp.Cells[row1 + 1, 6].Value2 = txt_DiaChiUV.Text;
            excelApp.Cells[row1 + 1, 7].Value2 = txt_ChungChi.Text;


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

        void insert_datauv()
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

            row = DangNhap.Ungvien.NewRow();
            row["TaiKhoan"] = excelRange.Cells[r, 1].Value2.ToString(); //string
            row["HoTen"] = excelRange.Cells[r, 2].Value2.ToString(); //string
            row["Mail"] = excelRange.Cells[r, 3].Value2.ToString(); //string
            row["SDT"] = excelRange.Cells[r, 4].Value2.ToString();
            row["NgaySinh"] = excelRange.Cells[r, 5].Value2.ToString(); //string
            row["DiaChi"] = excelRange.Cells[r, 6].Value2.ToString(); //string
            row["BangCap"] = excelRange.Cells[r, 7].Value2.ToString(); //string//string
            DangNhap.Ungvien.Rows.Add(row);
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

        bool check1()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataAcc = Path.Combine(executableLocation, "account.xlsx");

            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAcc);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int row = excelRange.Rows.Count;

            for (int i = 2; i <= row; i++)  // <= CountRowsJobs
            {
                if (excelApp.Cells[i, 1].Value2 == txtTaiKhoan.Text || excelApp.Cells[i, 1].Value2 == txt_TenTK.Text)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
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
                    return false;
                }
            }

            for (int i = 2; i <= row; i++)  // <= CountRowsJobs
            {
                if (excelApp.Cells[i, 5].Value2 == txt_EmailCT.Text)
                {
                    MessageBox.Show("Email đã tồn tại!");
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
                    return false;
                }
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

            return true;
        }

        bool check2()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataAcc = Path.Combine(executableLocation, "account.xlsx");

            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAcc);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int row = excelRange.Rows.Count;

            for (int i = 2; i <= row; i++)
            {
                if (excelApp.Cells[i, 1].Value2 == txt_TenTK.Text)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
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
                    return false;
                }
            }

            for (int i = 2; i <= row; i++)
            {
                if (excelApp.Cells[i, 5].Value2 == txt_Mail.Text)
                {
                    MessageBox.Show("Email đã tồn tại!");
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
                    return false;
                }
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

            return true;
        }


        private void bnt_DkTD_Click(object sender, EventArgs e)
        {
            if (check_null())
                if (check1())
                {
                    if (check_mk(txt_MK.Text, txt_NhapLai.Text))
                    {
                        string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        string DataAcc = Path.Combine(executableLocation, "account.xlsx");

                        //Create COM Objects.
                        ExcelApp.Application excelApp = new ExcelApp.Application();
                        //Notice: Change this path to your real excel file path
                        ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAcc);
                        ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                        ExcelApp.Range excelRange = excelSheet.UsedRange;

                        int row = excelRange.Rows.Count;

                        excelApp.Cells[row + 1, 1].Value2 = txt_TenTK.Text;
                        excelApp.Cells[row + 1, 2].Value2 = txt_MK.Text;
                        excelApp.Cells[row + 1, 3].Value2 = txt_TenCT.Text;
                        excelApp.Cells[row + 1, 4].Value2 = "0";
                        excelApp.Cells[row + 1, 5].Value2 = txt_EmailCT.Text;

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

                        DataRow drow = DangNhap.DataAcc.NewRow();
                        drow["TenDangNhap"] = txt_TenTK.Text; //string
                        drow["MatKhau"] = txt_MK.Text; //string
                        drow["Ten"] = txt_TenCT.Text; //string
                        drow["LoaiTK"] = "0";
                        drow["Mail"] = txt_EmailCT.Text;
                        //string
                        DangNhap.DataAcc.Rows.Add(drow);

                        insert_data_company();
                        insert_dataCT();
                        EmailSendCV();
                        MessageBox.Show("Tạo tài khoản nhà tuyển dụng thành công.");

                        this.Close();
                    }
                }
        }

        public void EmailSendCV()
        {
            string body = "Dear " + txt_TenCT.Text + ",\n" +
                            "Cảm ơn bạn đã tạo tài khoản nhà tuyển dụng với ứng dụng tìm kiếm việc làm IT." +
                            "\nTên tài khoản:" + txt_TenTK.Text +
                            "\nMật khẩu:" + txt_MK.Text;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("itjobs271102@gmail.com");
                mail.To.Add(txt_EmailCT.Text);
                mail.Subject = "Đã tạo tài khoản thành công";
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("itjobs271102@gmail.com", "skqoeqfwydllpfgx");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to send email. Error : " + ex);
            }
        }

        public void EmailSendCV_UV()
        {
            string body = "Dear " + txt_Name.Text + ",\n" +
                            "Cảm ơn bạn đã tạo tài khoản với ứng dụng tìm kiếm việc làm IT." +
                            "\nTên tài khoản:" + txtTaiKhoan.Text +
                            "\nMật khẩu:" + txtMatKhau.Text;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("itjobs271102@gmail.com");
                mail.To.Add(txt_Mail.Text);
                mail.Subject = "Đã tạo tài khoản thành công";
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("itjobs271102@gmail.com", "skqoeqfwydllpfgx");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to send email. Error : " + ex);
            }
        }
        void insert_data_company()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataAccUV = Path.Combine(executableLocation, "congty.xlsx");

            ExcelApp.Application excelApp = new ExcelApp.Application();
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAccUV);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            int row1 = excelRange.Rows.Count;

            excelApp.Cells[row1 + 1, 1].Value2 = row1;
            excelApp.Cells[row1 + 1, 2].Value2 = txt_TenCT.Text;
            excelApp.Cells[row1 + 1, 3].Value2 = txt_diachiCT.Text;
            if (txt_SLNV.Text == "")
                excelApp.Cells[row1 + 1, 4].Value2 = "None";
            else
                excelApp.Cells[row1 + 1, 4].Value2 = txt_SLNV.Text;
            if (txt_Mota.Text == "")
                excelApp.Cells[row1 + 1, 5].Value2 = "None";
            else
                excelApp.Cells[row1 + 1, 5].Value2 = txt_Mota.Text;
            excelApp.Cells[row1 + 1, 6].Value2 = logo;


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

        void insert_dataCT()
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
            row = DangNhap.DataComp.NewRow();
            row["STT"] = excelRange.Cells[r, 1].Value2.ToString(); //string
            row["TenCongTy"] = excelRange.Cells[r, 2].Value2.ToString(); //string
            row["DiaChi"] = excelRange.Cells[r, 3].Value2.ToString(); //string
            row["SoNV"] = excelRange.Cells[r, 4].Value2.ToString(); //string
            row["MoTa"] = excelRange.Cells[r, 5].Value2.ToString(); //string
            row["Logo"] = excelRange.Cells[r, 6].Value2.ToString(); //string

            DangNhap.DataComp.Rows.Add(row);
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

        public void CopyFile(string sourceFile, string fileName, int check)
        {
            string targetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (check == 0)
            {
                targetPath += "/Logo";
            }
            string destFile = Path.Combine(targetPath, fileName);

            File.Copy(sourceFile, destFile, true);
        }
        string logoPath = "";
        int fl_logo = 0;
        private void btn_chon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var filePath = dlg.FileName;
                string ext = Path.GetExtension(filePath);
                logoPath = filePath;
                //UCRegEmp_lb_FileLogoName.Text = Path.GetFileName(filePath);
                //UCRegEmp_lb_FileLogoName.ForeColor = Color.Black;
                logo = Path.GetFileName(filePath);
                CopyFile(logoPath, Path.GetFileName(filePath), 0);
                pic_avtct.ImageLocation = logoPath;
                fl_logo = 1;
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng ký tài khoản";
            if (DangNhap.f_dk < 2)
            {
                DataAccount.Columns.Add("TenTK", typeof(string));
                DataAccount.Columns.Add("MatKhau", typeof(string));
                DataAccount.Columns.Add("TenCT", typeof(string));
                DataAccount.Columns.Add("Loai", typeof(string));
            }

        }

        void Insert_dataaccc()
        {
            DataRow row = DangNhap.DataAcc.NewRow();
            row["TenDangNhap"] = txt_TenTK.Text; //string
            row["MatKhau"] = txt_MK.Text; //string
            row["Ten"] = txt_TenCT.Text; //string
            row["LoaiTK"] = "0";
            row["Mail"] = txt_EmailCT.Text;
            //string
            DangNhap.DataAcc.Rows.Add(row);
        }
        bool check_null()
        {
            if (txt_TenTK.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được bỏ trống!");
                return false;
            }

            if (txt_MK.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!");
                return false;
            }
            if (txt_EmailCT.Text == "")
            {
                MessageBox.Show("Email không được bỏ trống!");
                return false;
            }
            if (txt_diachiCT.Text == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống!");
                return false;
            }
            if (txt_TenCT.Text == "")
            {
                MessageBox.Show("Tên công ty không được bỏ trống!");
                return false;
            }
            if (fl_logo == 0)
            {
                MessageBox.Show("Chưa chọn logo công ty!");
                return false;
            }
            return true;
        }

        bool check_null2()
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được bỏ trống!");
                return false;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!");
                return false;
            }
            if (txt_Mail.Text == "")
            {
                MessageBox.Show("Email không được bỏ trống!");
                return false;
            }

            if (txt_Name.Text == "")
            {
                MessageBox.Show("Tên không được bỏ trống!");
                return false;
            }
            return true;
        }

        private void hopeTabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
