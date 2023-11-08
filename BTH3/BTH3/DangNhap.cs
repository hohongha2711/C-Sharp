using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        DataTable account = Play.acc;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txt_tendangnhap.Texts;  
            string matkhau = txt_matkhau.Texts;
            //MessageBox.Show(rjTextBox1.Texts);
            DataRow[] dr = account.Select("ID = '" + tendangnhap + "'AND MatKhau = '" + matkhau + "'");
            if (dr.Length > 0)
            {
                Play.login = 1;
                Play.name = dr[0]["Ten"].ToString();
                Play.id = tendangnhap;
                this.Close();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
