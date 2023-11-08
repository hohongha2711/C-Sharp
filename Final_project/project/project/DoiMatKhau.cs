using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.IO;

namespace project
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        string ten = "";
        void update()
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
                if (excelApp.Cells[i, 1].Value2.ToString() == txt_TenTK.Text)
                {
                    excelApp.Cells[i, 2].Value2 = txt_MK.Text;
                    break;
                }    
                   
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

            MessageBox.Show("Thay đổi mật khẩu thành công!");
        }
        string s = "";
        public void EmailSendCV()
        {
            
            Random rd = new Random();
            int Numrd = rd.Next(100000, 999999);
            s = Numrd.ToString();
            string body = "Dear " + ten + ",\n" +
                            "Bạn đã yêu cầu cấp lại mật khẩu cho tài khoản"+ txt_TenTK.Text + 
                            "\nMã xác nhận là:" + Numrd.ToString();
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("itjobs271102@gmail.com");
                mail.To.Add(txt_Mail.Text);
                mail.Subject = "Yêu cầu cấp lại mật khẩu tài khoản";
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

        bool check()
        {
            DataRow[] dtr = DangNhap.DataAcc.Select("TenDangNhap = '" + txt_TenTK.Text+"'");
            if(dtr.Length == 0)
            {
                MessageBox.Show("Tên tài khoản không tồn tại!");
                return false;
            }

            if (dtr[0]["Mail"].ToString() != txt_Mail.Text)
            {
                MessageBox.Show("Email không đúng!");
                return false;
            }

            ten = dtr[0]["Ten"].ToString();

            return true;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ThayDoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ThayDoi_Click_1(object sender, EventArgs e)
        {
            if (txt_MK.Text == "")
                MessageBox.Show("Chưa nhập mật khẩu mới!");
            else if (txt_MK.Text != txt_NhapLai.Text)
                MessageBox.Show("Mật khẩu không khớp!");
            else
            {
                update();
                update_acc();
                this.Close();
            }    
                
        }

        private void btn_Ok_Click_1(object sender, EventArgs e)
        {
            if (txt_Ma.Text.ToString() == s)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (check())
            {
                EmailSendCV();
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }
        void update_acc()
        {
            DataTable acc = new DataTable();

            acc.Columns.Add("TenDangNhap", typeof(string));
            acc.Columns.Add("MatKhau", typeof(string));
            acc.Columns.Add("Ten", typeof(string));
            acc.Columns.Add("LoaiTK", typeof(string));
            acc.Columns.Add("Mail", typeof(string));

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
                row = acc.NewRow();
                row["TenDangNhap"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                row["MatKhau"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                row["Ten"] = excelRange.Cells[i, 3].Value2.ToString(); //string
                row["LoaiTK"] = excelRange.Cells[i, 4].Value2.ToString();
                row["Mail"] = excelRange.Cells[i, 5].Value2.ToString();
                //string
                acc.Rows.Add(row);
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
            DangNhap.DataAcc = acc;

        }
    }
}
