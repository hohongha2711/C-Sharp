using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace project
{
    public partial class Apply : Form
    {
        public Apply()
        {
            InitializeComponent();
        }
        bool check = false;
        string fileCVPath = "";
        string company_name = "";
        private void FormApply_bt_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var filePath = dlg.FileName;
                string ext = Path.GetExtension(filePath);
                if (ext != ".pdf")
                {
                    lb_FileName.Text = "Vui lòng chọn lại CV đúng yêu cầu";
                    lb_FileName.ForeColor = Color.Red;
                }
                else
                {
                    lb_FileName.Text = Path.GetFileName(filePath);
                    fileCVPath = filePath;
                    lb_FileName.ForeColor = Color.Black;
                    check = true;
                    CopyFile(filePath, lb_FileName.Text);
                }
            }
        }
        string getCurrentDateTime()
        {
            return string.Format("{0}-{1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"));
        }
        void InsertAccExcel()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataAccEmp = Path.Combine(executableLocation, "Apply.xlsx");

            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAccEmp);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int row = excelRange.Rows.Count;

            excelApp.Cells[row + 1, 1].Value2 = company_name;
            excelApp.Cells[row + 1, 2].Value2 = lb_TenCongViec.Text;
            excelApp.Cells[row + 1, 3].Value2 = txt_Name.Text;
            excelApp.Cells[row + 1, 4].Value2 = txt_email.Text;
            excelApp.Cells[row + 1, 5].Value2 = getCurrentDateTime();
            excelApp.Cells[row + 1, 6].Value2  = lb_FileName.Text;
            excelApp.Cells[row + 1, 7].Value2 = DangNhap.tendangnhap;

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


        public void CopyFile(string sourceFile, string fileName)
        {
            string targetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            targetPath += "/CV";

            string destFile = Path.Combine(targetPath, fileName);

            File.Copy(sourceFile, destFile, true);
        }

        private void FormApply_bt_SendCV_Click(object sender, EventArgs e)
        {
            if (check)
            {
                InsertAccExcel();
                EmailSendCV();
                MessageBox.Show("Bạn đã gửi CV thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file CV");
            }

        }

        public void EmailSendCV()
        {
            string body = "Dear " + DangNhap.ten + ",\n" +
                            "Bạn đã gửi CV của mình đến công ty" + company_name +
                            "\nCông việc ứng tuyển:" + lb_TenCongViec.Text;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("itjobs271102@gmail.com");
                mail.To.Add(txt_email.Text);
                mail.Subject = "Xác nhận đã gửi CV thành công";
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
        private void Apply_Load(object sender, EventArgs e)
        {
            if(Main.fl_ap == 0)
            {
                company_name = CongViec.com_name;
                lb_TenCongViec.Text = CongViec.job_name;
                this.Text = "Apply " + CongViec.job_name;
            }
            else
            {
                int t = NguoiUngTuyen.i;
                company_name = NguoiUngTuyen.dr[t]["TenCongTy"].ToString();
                lb_TenCongViec.Text = NguoiUngTuyen.dr[t]["TenCongViec"].ToString();
                this.Text = "Apply " + NguoiUngTuyen.dr[t]["TenCongViec"].ToString();
            }
        }

        private void lb_TenCongViec_Click(object sender, EventArgs e)
        {

        }
    }
}
