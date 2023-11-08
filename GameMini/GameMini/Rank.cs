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
    public partial class Rank : Form
    {
        public Rank()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Rank_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_Topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Sql = "";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Nam3_HK1\\C#\\BTTH\\GameMini\\GameMini\\GameMini.mdf;Integrated Security=True");
            con.Open();
            if (comboBox_Topic.SelectedItem.ToString() == "Fruit")
            {
                Sql = "Select top 5 * from Rank where Topic = 'Fruit' order by Score DESC,Time DESC";
            }
            else if (comboBox_Topic.SelectedItem.ToString() == "Vehicle")
            {
                Sql = "Select top 5 * from Rank where Topic = 'Vehicle' order by Score DESC,Time DESC";
            }
            else if (comboBox_Topic.SelectedItem.ToString() == "Animal")
            {
                Sql = "Select top 5 * from Rank where Topic = 'Animal' order by Score DESC,Time DESC";
            }
            else if (comboBox_Topic.SelectedItem.ToString() == "Sport")
            {
                Sql = "Select top 5 * from Rank where Topic = 'Sport' order by Score DESC,Time DESC";
            }
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);  
            con.Close(); 
            dataGridView1.DataSource = dt;
        }
    }
}
