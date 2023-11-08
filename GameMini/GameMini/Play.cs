using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GameMini
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }


        int score = 0;
        int count = 0;
        List<int> list_select = new List<int>();


        private List<int> Select()
        {
            int temp;
            Random rand = new Random();
            List<int> list = new List<int>();
            List<int> list_result = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < 10; i++)
            {
                temp = rand.Next(list.Count);

                list_result.Add(list[temp]);
                list.RemoveAt(temp);
            }
            return list_result;
        }
        public void Loaddata(string s, int i)
        {
            if (s == "Fruit")
                switch (i)
                {
                    case 0:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.apple;
                            Share.result = "apple";
                            break;
                        }
                    case 1:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.banana;
                            Share.result = "banana";
                            break;
                        }
                    case 2:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.cherry;
                            Share.result = "cherry";
                            break;
                        }
                    case 3:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.kiwi;
                            Share.result = "kiwi";
                            break;
                        }
                    case 4:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.lemon;
                            Share.result = "lemon";
                            break;
                        }
                    case 5:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.mango;
                            Share.result = "mango";
                            break;
                        }
                    case 6:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.orange;
                            Share.result = "orange";
                            break;
                        }
                    case 7:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.pineapple;
                            Share.result = "pineapple";
                            break;
                        }
                    case 8:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.strawberry;
                            Share.result = "strawberry";
                            break;
                        }
                    case 9:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.watermelon;
                            Share.result = "watermelon";
                            break;
                        }
                }
            else if (s == "Vehicle")
                switch (i)
                {
                    case 0:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.boat;
                            Share.result = "boat";
                            break;
                        }
                    case 1:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.bus;
                            Share.result = "bus";
                            break;
                        }
                    case 2:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.car;
                            Share.result = "car";
                            break;
                        }
                    case 3:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.cycle;
                            Share.result = "cycle";
                            break;
                        }
                    case 4:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.motobike;
                            Share.result = "motobike";
                            break;
                        }
                    case 5:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.plane;
                            Share.result = "plane";
                            break;
                        }
                    case 6:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.ship;
                            Share.result = "ship";
                            break;
                        }
                    case 7:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.taxi;
                            Share.result = "taxi";
                            break;
                        }
                    case 8:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.train;
                            Share.result = "train";
                            break;
                        }
                    case 9:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.truck;
                            Share.result = "truck";
                            break;
                        }
                }
            else if (s == "Animal")
                switch (i)
                {
                    case 0:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.buffalo;
                            Share.result = "buffalo";
                            break;
                        }
                    case 1:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.cat;
                            Share.result = "cat";
                            break;
                        }
                    case 2:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.chicken;
                            Share.result = "chicken";
                            break;
                        }
                    case 3:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.dog;
                            Share.result = "dog";
                            break;
                        }
                    case 4:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.elephant;
                            Share.result = "elephant";
                            break;
                        }
                    case 5:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.horse;
                            Share.result = "horse";
                            break;
                        }
                    case 6:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.lion;
                            Share.result = "lion";
                            break;
                        }
                    case 7:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.monkey;
                            Share.result = "monkey";
                            break;
                        }
                    case 8:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.panda;
                            Share.result = "panda";
                            break;
                        }
                    case 9:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.tiger;
                            Share.result = "tiger";
                            break;
                        }
                }
            else if (s == "Sport")
                switch (i)
                {
                    case 0:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.archery;
                            Share.result = "archery";
                            break;
                        }
                    case 1:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.badminton;
                            Share.result = "badminton";
                            break;
                        }
                    case 2:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.baseball;
                            Share.result = "baseball";
                            break;
                        }
                    case 3:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.basketball;
                            Share.result = "basketball";
                            break;
                        }
                    case 4:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.boxing;
                            Share.result = "boxing";
                            break;
                        }
                    case 5:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.fishing;
                            Share.result = "fishing";
                            break;
                        }
                    case 6:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.golf;
                            Share.result = "golf";
                            break;
                        }
                    case 7:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.running;
                            Share.result = "running";
                            break;
                        }
                    case 8:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.soccer;
                            Share.result = "soccer";
                            break;
                        }
                    case 9:
                        {
                            pictureBox1.Image = global::GameMini.Properties.Resources.weightlifting;
                            Share.result = "weightlifting";
                            break;
                        }
                }

        }

        private void Play_Load(object sender, EventArgs e)
        {
            
            Panel pnlTop = new Panel() { Height = 2, Dock = DockStyle.Top, BackColor = Color.Green };
            this.Controls.Add(pnlTop);

            Panel pnlRight = new Panel() { Width = 2, Dock = DockStyle.Right, BackColor = Color.Green };
            this.Controls.Add(pnlRight);

            Panel pnlBottom = new Panel() { Height = 2, Dock = DockStyle.Bottom, BackColor = Color.Green };
            this.Controls.Add(pnlBottom);

            Panel pnlLeft = new Panel() { Width = 2, Dock = DockStyle.Left, BackColor = Color.Green };
            this.Controls.Add(pnlLeft);

            lb_Topic.Text = Share.Topic;
            list_select = Select();
            pic_Correct.Visible = false;
            pic_Incorrect.Visible = false;
            if (Share.Mute == true)
            {
                pictureBox_Volume.Visible = false;
                pictureBox_Mute.Visible = true;
            }
            else
            {
                pictureBox_Volume.Visible = true;
                pictureBox_Mute.Visible = false;
            }
            Loaddata(Share.Topic, list_select[0]);
            count++;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wmplayer1 = new WMPLib.WindowsMediaPlayer();
            
            pic_Next.Enabled = true;
            if (txt_Answer.Text == Share.result)
            {
                pic_Correct.Visible = true;
                score += 2;
                lb_Score.Text = score.ToString();
                switch (count)
                {
                    case 1:
                        pictureBox_1.BackColor = Color.Green;
                        break;
                    case 2:
                        pictureBox_2.BackColor = Color.Green;
                        break;
                    case 3:
                        pictureBox_3.BackColor = Color.Green;
                        break;
                    case 4:
                        pictureBox_4.BackColor = Color.Green;
                        break;
                    case 5:
                        pictureBox_5.BackColor = Color.Green;
                        break;
                }
            }
            else
            {
                pic_Incorrect.Visible = true;
                switch (count)
                {
                    case 1:
                        pictureBox_1.BackColor = Color.Red;
                        break;
                    case 2:
                        pictureBox_2.BackColor = Color.Red;
                        break;
                    case 3:
                        pictureBox_3.BackColor = Color.Red;
                        break;
                    case 4:
                        pictureBox_4.BackColor = Color.Red;
                        break;
                    case 5:
                        pictureBox_5.BackColor = Color.Red;
                        break;
                }
            }
            if (count == 5)
                pic_Finish.Enabled = true;
            btn_Check.Enabled = false;

        }

        private void pictureBox_Volume_Click(object sender, EventArgs e)
        {
            pictureBox_Volume.Visible = false;
            pictureBox_Mute.Visible = true;
            Share.wmplayer.controls.pause();
        }

        private void pictureBox_Mute_Click(object sender, EventArgs e)
        {
            pictureBox_Volume.Visible = true;
            pictureBox_Mute.Visible = false;
            Share.wmplayer.controls.play();
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close all window?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            { }
        }

        private void pic_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pic_Next_Click(object sender, EventArgs e)
        {
            pic_Next.Enabled = false;
            btn_Check.Enabled = true;
            txt_Answer.Text = "";
            Loaddata(Share.Topic, list_select[count]);
            pic_Correct.Visible = false;
            pic_Incorrect.Visible = false;
            count++;
            if (count == 5)
            {
                pic_Next.Visible = false;
                pic_Finish.Visible = true;
            }    
                
        }
        private int createID()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Nam3_HK1\\C#\\BTTH\\GameMini\\GameMini\\GameMini.mdf;Integrated Security=True");
            string Sql = "Select top(1) ID from Rank order by ID DESC";
            SqlCommand cmd = new SqlCommand(Sql, con);
            con.Open();
            string id = ((int)cmd.ExecuteScalar()).ToString();
            con.Close();
            if (id == null)
                return 1;
            else
            {
                return (Int32.Parse(id) + 1);
            }    
               
        }
        private void pic_Finish_Click(object sender, EventArgs e)
        {
            //Share.IDname++;
            label_Sco.Text = lb_Score.Text;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Nam3_HK1\\C#\\BTTH\\GameMini\\GameMini\\GameMini.mdf;Integrated Security=True");

            String Sql = "INSERT into Rank (ID, Score, Topic, Time) VALUES(@ID,@Score,@Topic,@Time)";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.Parameters.AddWithValue("@ID", createID());
            cmd.Parameters.AddWithValue("@Score", Int32.Parse(lb_Score.Text));
            cmd.Parameters.AddWithValue("@Topic", Share.Topic);
            cmd.Parameters.AddWithValue("@Time", DateTime.Now);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException a)
            {
                Console.WriteLine("Error Generated. Details: " + a.ToString());
            }
            con.Close();
            groupBox_Finish.Visible = true;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Return_MouseLeave(object sender, EventArgs e)
        {
            pic_Return.BackColor = Color.Empty;
        }      

        
    }
}
