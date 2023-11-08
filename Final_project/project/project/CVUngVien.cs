using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class CVUngVien : Form
    {
        public CVUngVien()
        {
            InitializeComponent();
        }

        private void CVUngVien_Load(object sender, EventArgs e)
        {
            this.Text = "Xem CV ứng viên";
            string targetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            targetPath += "/CV/";
            targetPath += NhaTuyenDung.cv;
            axAcroPDF1.src = targetPath;
        }

        private void axAcroPDF2_Enter(object sender, EventArgs e)
        {

        }

        private void CVUngVien_Load_1(object sender, EventArgs e)
        {

        }
    }
}
