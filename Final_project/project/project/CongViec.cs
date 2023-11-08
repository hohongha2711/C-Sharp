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
using static GMap.NET.Entity.OpenStreetMapGeocodeEntity;
using static System.Net.Mime.MediaTypeNames;
using ExcelApp = Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace project
{
    public partial class CongViec : Form
    {
        public CongViec()
        {
            InitializeComponent();
        }

        DataRow[] dr;
        DataRow[] d;
        private void CongViec_Load(object sender, EventArgs e)
        {
            if(DangNhap.fl_nhatuyendung == 1)
            {
                btn_apply.Visible = false;
                btn_luu.Visible = false;
            }
            else
            {
                btn_apply.Visible = true;
                btn_luu.Visible = true;
            }
            this.Text = "Thông tin chi tiết công việc";
            dr = Main.dr;
            lb_luong.Text = dr[Main.curent]["MucLuong"].ToString();
            lb_diachi.Text = dr[Main.curent]["DiaChi"].ToString();
            string congty = dr[Main.curent]["CongTy"].ToString();
            d = Main.DataCompany.Select("STT = '" + congty + "'");
            string targetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            targetPath += "/Logo/";
            targetPath += d[0]["Logo"].ToString();
            pic_avt.ImageLocation = targetPath;

            lb_tencv.Text = dr[Main.curent]["TenCongViec"].ToString();
            lb_tenct.Text = d[0]["TenCongTy"].ToString();

            string mota = dr[Main.curent]["MoTa"].ToString();
            mota = mota.Replace(".-", "\n- ");
            mota = mota.Replace(". -", "\n- ");
            mota = mota.Replace(". ***", "\n- ");
            mota = mota.Replace(".***", "\n- ");
            txt_Mota.Text = mota;

            string yeucau = dr[Main.curent]["YeuCau"].ToString();
            yeucau = yeucau.Replace(".-", "\n- ");
            yeucau = yeucau.Replace(". -", "\n- ");
            yeucau = yeucau.Replace(". ***", "\n- ");
            yeucau = yeucau.Replace(".***", "\n- ");
            txt_YeuCau.Text = yeucau;

            string chitiet = d[0]["MoTa"].ToString();
            chitiet = chitiet.Replace(".-", "\n- ");
            chitiet = chitiet.Replace(". -", "\n- ");
            chitiet = chitiet.Replace(". ***", "\n- ");
            chitiet = chitiet.Replace(".***", "\n- ");
            txt_chitiet.Text = chitiet;
            string s;
            s = dr[Main.curent]["TenLienHe"].ToString();
            if (s == "None")
                s = "";
            tenLH.Text = s;

            s = dr[Main.curent]["SDT"].ToString();
            if (s == "None")
                s = "";
            if (s.Length == 9)
                s = "0" + s;
            SDT.Text = s;

            s = dr[Main.curent]["Mail"].ToString();
            if (s == "None")
                s = "";
            mail.Text = s;

            s = dr[Main.curent]["DiaChiLienHe"].ToString();
            if (s == "None")
                s = "";
            diachi.Text = s;

            s = dr[Main.curent]["Note"].ToString();
            if (s == "None")
                s = "";
            note.Text = s;

            s = d[0]["SoNV"].ToString();
            SLNV.Text = s;

            s = d[0]["DiaChi"].ToString();
            bigLabel15.Text = s;
      }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataAccEmp = Path.Combine(executableLocation, "Save.xlsx");

            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAccEmp);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int row = excelRange.Rows.Count;

            excelApp.Cells[row + 1, 1].Value2 = DangNhap.tendangnhap;
            excelApp.Cells[row + 1, 2].Value2 = lb_tencv.Text;
            excelApp.Cells[row + 1, 3].Value2 = lb_tenct.Text;
            excelApp.Cells[row + 1, 4].Value2 = lb_luong.Text;

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
            MessageBox.Show("Đã lưu công việc thành công");
        }
        public static string com_name = "";
        public static string job_name = "";
        private void btn_apply_Click(object sender, EventArgs e)
        {
            com_name = d[0]["TenCongTy"].ToString();
            job_name = lb_tencv.Text;
            Main.fl_ap = 0;
            Apply dk = new Apply();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mail_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = mail.Text;
            // body, bcc etc...
            oMailItem.Display(true);
        }

        private void txt_Mota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
