using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMini
{
    public partial class Vocabulary : Form
    {
        public Vocabulary()
        {
            InitializeComponent();
        }

        private void Vocabulary_Load(object sender, EventArgs e)
        {
            Panel pnlTop = new Panel() { Height = 2, Dock = DockStyle.Top, BackColor = Color.Green };
            this.Controls.Add(pnlTop);

            Panel pnlRight = new Panel() { Width = 2, Dock = DockStyle.Right, BackColor = Color.Green };
            this.Controls.Add(pnlRight);

            Panel pnlBottom = new Panel() { Height = 2, Dock = DockStyle.Bottom, BackColor = Color.Green };
            this.Controls.Add(pnlBottom);

            Panel pnlLeft = new Panel() { Width = 2, Dock = DockStyle.Left, BackColor = Color.Green };
            this.Controls.Add(pnlLeft);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Vocabulary");

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("En", typeof(string));
            dt.Columns.Add("Vn", typeof(string));
            if (comboBox_Topic.SelectedItem.ToString() == "Fruit")
            {

                
                dt.Rows.Add("1", "Apple", "Quá Táo");
                dt.Rows.Add("2", "Banana", "Quả chuối");
                dt.Rows.Add("3", "Cherry", "Quả cherry");
                dt.Rows.Add("4", "Kiwi", "Quả kiwi");
                dt.Rows.Add("5", "Lemon", "Quả chanh");
                dt.Rows.Add("6", "Melon", "Quả xoài");
                dt.Rows.Add("7", "Orange", "Quả cam");
                dt.Rows.Add("8", "Pineapple", "Quả dứa/Quả thơm");
                dt.Rows.Add("9", "Strawberry", "Quả dâu tây");
                dt.Rows.Add("10", "Watermelon", "Quả dưa hấu");
            }
            else if (comboBox_Topic.SelectedItem.ToString() == "Vehicle")
            {
                dt.Rows.Add("1", "Boat", "Thuyền");
                dt.Rows.Add("2", "Bus", "Xe buýt");
                dt.Rows.Add("3", "Car", "Xe con");
                dt.Rows.Add("4", "Cycle", "Xe đạp");
                dt.Rows.Add("5", "Motobike", "Xe máy");
                dt.Rows.Add("6", "Plane", "Máy bay");
                dt.Rows.Add("7", "Ship", "Tàu biển");
                dt.Rows.Add("8", "Taxi", "Xe taxi");
                dt.Rows.Add("9", "Train", "Tàu hoả");
                dt.Rows.Add("10", "Truck", "Xe tải");
            }
            else if (comboBox_Topic.SelectedItem.ToString() == "Animal")
            {
                dt.Rows.Add("1", "Buffalo", "Con trâu");
                dt.Rows.Add("2", "Cat", "Con mèo");
                dt.Rows.Add("3", "Chicken", "Con gà");
                dt.Rows.Add("4", "Dog", "Con chó");
                dt.Rows.Add("5", "Elephant", "Con voi");
                dt.Rows.Add("6", "Horse", "Con ngựa");
                dt.Rows.Add("7", "Lion", "Con sư tử");
                dt.Rows.Add("8", "Monkey", "Con khỉ");
                dt.Rows.Add("9", "Tiger", "Con hổ");
                dt.Rows.Add("10", "Zebra", "Ngựa vằn");
            }
            else if (comboBox_Topic.SelectedItem.ToString() == "Sport")
            {
                dt.Rows.Add("1", "Archery", "Bắn cung");
                dt.Rows.Add("2", "Badminton", "Cầu lông");
                dt.Rows.Add("3", "Baseball", "Bóng chày");
                dt.Rows.Add("4", "Basketball", "Bóng rổ");
                dt.Rows.Add("5", "Boxing", "Đấm bốc");
                dt.Rows.Add("6", "Fishing", "Câu cá");
                dt.Rows.Add("7", "Golf", "Đánh gôn");
                dt.Rows.Add("8", "Running", "Chạy bộ");
                dt.Rows.Add("9", "Soccer", "Bóng đá");
                dt.Rows.Add("10", "Weightlifting", "Cử tạ");
            }
           
            dataGridView1.DataSource = dt;

        }
    }
}
