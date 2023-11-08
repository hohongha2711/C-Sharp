using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMini
{
    public partial class Topic : Form
    {
        public Topic()
        {
            InitializeComponent();
        }

        private void btn_Fruit_Click(object sender, EventArgs e)
        {
            Share.Topic = "Fruit";
            Play dlg = new Play();
            this.Visible = false;
            dlg.ShowDialog();
            this.Visible = true;
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

        private void btn_Vehicle_Click(object sender, EventArgs e)
        {
            Share.Topic = "Vehicle";
            Play dlg = new Play();
            this.Visible = false;
            dlg.ShowDialog();
            this.Visible = true;
        }

        private void btn_Animal_Click(object sender, EventArgs e)
        {
            Share.Topic = "Animal";
            Play dlg = new Play();
            this.Visible = false;
            dlg.ShowDialog();
            this.Visible = true;
        }

        private void btn_Sport_Click(object sender, EventArgs e)
        {
            Share.Topic = "Sport";
            Play dlg = new Play();
            this.Visible = false;
            dlg.ShowDialog();
            this.Visible = true;
        }

        private void btn_Fruit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Fruit.BackColor = Color.Green;
        }

        private void btn_Fruit_MouseLeave(object sender, EventArgs e)
        {
            btn_Fruit.BackColor = Color.Chartreuse;
        }

        private void btn_Animal_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Animal.BackColor = Color.Green;
        }

        private void btn_Animal_MouseLeave(object sender, EventArgs e)
        {
            btn_Animal.BackColor = Color.Chartreuse;
        }

        private void btn_Vehicle_MouseLeave(object sender, EventArgs e)
        {
            btn_Vehicle.BackColor = Color.Chartreuse;    
        }

        private void btn_Vehicle_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Vehicle.BackColor= Color.Green;
        }

        private void btn_Sport_MouseLeave(object sender, EventArgs e)
        {
            btn_Sport.BackColor = Color.Chartreuse;  
        }

        private void btn_Sport_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Sport.BackColor= Color.Green;
        }

        private void Topic_Load(object sender, EventArgs e)
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

        
    }
}
