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
using Newtonsoft.Json.Linq;

namespace project
{
    public partial class DangCongViec : Form
    {
        public DangCongViec()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dang_Click(object sender, EventArgs e)
        {
            insert_CongViecdata();
            MessageBox.Show("Đăng công việc thành công!");
            this.Close();
        }

        string get_company(string s)
        {
            string c = "0";
            DataRow[] drr = DangNhap.DataComp.Select("TenCongTy = '" + s + "'");
            c = drr[0]["STT"].ToString();
            return c;
        }
        void insert_CongViecdata()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataAccEmp = Path.Combine(executableLocation, "Congviec_data.xlsx");

            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAccEmp);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int row = excelRange.Rows.Count;
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 1].Value2 = txt_Ten.Text;
            else
                excelApp.Cells[row + 1, 1].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 2].Value2 = get_company(lb_tenct.Text);
            else
                excelApp.Cells[row + 1, 2].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 3].Value2 = txt_Diachi.Text;
            else
                excelApp.Cells[row + 1, 3].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 4].Value2 = txt_Luong.Text;
            else
                excelApp.Cells[row + 1, 4].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 5].Value2 = txt_mota.Text;
            else
                excelApp.Cells[row + 1, 5].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 6].Value2 = txt_yeucau.Text;
            else
                excelApp.Cells[row + 1, 6].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 7].Value2 = txt_LienHe.Text;
            else
                excelApp.Cells[row + 1, 7].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 8].Value2 = txt_SDT.Text;
            else
                excelApp.Cells[row + 1, 8].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 9].Value2 = txt_Mail.Text;
            else
                excelApp.Cells[row + 1, 9].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 10].Value2 = txt_diachilh.Text;
            else
                excelApp.Cells[row + 1, 10].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 11].Value2 = txt_note.Text;
            else
                excelApp.Cells[row + 1, 11].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 12].Value2 = listBox_LinhVuc.Text;
            else
                excelApp.Cells[row + 1, 12].Value2 = "None";
            if (txt_Ten.Text != "")
                excelApp.Cells[row + 1, 13].Value2 = lb_tenct.Text;
            else
                excelApp.Cells[row + 1, 13].Value2 = "None";

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

            DataRow row_add = DangNhap.DataJob.NewRow();
            row_add[0] = txt_Ten.Text;
            row_add[1] = get_company(lb_tenct.Text).ToString();
            row_add[2] = txt_Diachi.Text;
            row_add[3] = txt_Luong.Text;
            row_add[4] = txt_mota.Text;
            row_add[5] = txt_yeucau.Text;
            row_add[6] = txt_LienHe.Text;
            row_add[7] = txt_SDT.Text;
            row_add[8] = txt_Mail.Text;
            row_add[9] = txt_diachilh.Text;
            row_add[10] = txt_note.Text;
            row_add[11] = listBox_LinhVuc.Text;
            row_add[12] = lb_tenct.Text;
            DangNhap.DataJob.Rows.Add(row_add);
        }
        private void txt_Ten_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string DataAccEmp = Path.Combine(executableLocation, "Congviec_data.xlsx");

            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();
            //Notice: Change this path to your real excel file path
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DataAccEmp);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int row = excelRange.Rows.Count;
            int r = -1;
            string s = get_company(lb_tenct.Text).ToString();
            for (int i = 2; i <= row; i++)
                if (excelApp.Cells[i, 1].Value2 == txt_Ten.Text && excelApp.Cells[i, 2].Value2.ToString() == s)
                {
                    r = i;
                    break;
                }
            excelApp.Cells[r, 1].Value2 = txt_Ten.Text;
            excelApp.Cells[r, 2].Value2 = get_company(lb_tenct.Text);
            excelApp.Cells[r, 3].Value2 = txt_Diachi.Text;
            excelApp.Cells[r, 4].Value2 = txt_Luong.Text;
            excelApp.Cells[r, 5].Value2 = txt_mota.Text;
            excelApp.Cells[r, 6].Value2 = txt_yeucau.Text;
            excelApp.Cells[r, 7].Value2 = txt_LienHe.Text;
            excelApp.Cells[r, 8].Value2 = txt_SDT.Text;
            excelApp.Cells[r, 9].Value2 = txt_Mail.Text;
            excelApp.Cells[r, 10].Value2 = txt_diachilh.Text;
            excelApp.Cells[r, 11].Value2 = txt_note.Text;
            excelApp.Cells[r, 12].Value2 = listBox_LinhVuc.Text;
            excelApp.Cells[r, 13].Value2 = lb_tenct.Text;

            MessageBox.Show("Update thành công");
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

            DataTable d = DangNhap.DataJob;
            d.Rows[r - 2][0] = txt_Ten.Text;
            d.Rows[r - 2][1] = get_company(lb_tenct.Text).ToString();
            d.Rows[r - 2][2] = txt_Diachi.Text;
            d.Rows[r - 2][3] = txt_Luong.Text;
            d.Rows[r - 2][4] = txt_mota.Text;
            d.Rows[r - 2][5] = txt_yeucau.Text;
            d.Rows[r - 2][6] = txt_LienHe.Text;
            d.Rows[r - 2][7] = txt_SDT.Text;
            d.Rows[r - 2][8] = txt_Mail.Text;
            d.Rows[r - 2][9] = txt_diachilh.Text;
            d.Rows[r - 2][10] = txt_note.Text;
            d.Rows[r - 2][11] = listBox_LinhVuc.Text;
            d.Rows[r - 2][12] = lb_tenct.Text;
            DangNhap.DataJob = d;
        }

        private void DangCongViec_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng công việc mới";
            lb_tenct.Text = DangNhap.ten;
            if (NhaTuyenDung.flag > 0)
            {
                this.Text = "Cập nhật công việc";
                load();
                btn_update.Visible = true;
                btn_Dang.Visible = false;

            }

        }
        void load()
        {
            lb_tenct.Text = DangNhap.ten;
            listBox_LinhVuc.Text = NhaTuyenDung.drr1["LinhVuc"].ToString();
            txt_Ten.Text = NhaTuyenDung.drr1["TenCongViec"].ToString();
            txt_Diachi.Text = NhaTuyenDung.drr1["DiaChi"].ToString();
            txt_Luong.Text = NhaTuyenDung.drr1["MucLuong"].ToString();
            txt_mota.Text = NhaTuyenDung.drr1["MoTa"].ToString();
            txt_note.Text = NhaTuyenDung.drr1["Note"].ToString();
            txt_yeucau.Text = NhaTuyenDung.drr1["YeuCau"].ToString();
            txt_SDT.Text = NhaTuyenDung.drr1["SDT"].ToString();
            txt_Mail.Text = NhaTuyenDung.drr1["Mail"].ToString();
            txt_diachilh.Text = NhaTuyenDung.drr1["DiaChiLienHe"].ToString();
            txt_LienHe.Text = NhaTuyenDung.drr1["TenLienHe"].ToString();
        }
        private void txt_Diachi_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Diachi.Text == "Địa chỉ")
                txt_Diachi.Text = null;
        }

        private void txt_Luong_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Luong.Text == "Mức lương")
                txt_Luong.Text = null;
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
    }
}
