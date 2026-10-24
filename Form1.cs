using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIc_tac_toe_Project.Properties;

namespace TIc_tac_toe_Project
{
    public partial class Form1 : Form
    {
        bool LastPlay = false;
        short Counter;

        public Form1()
        {
            InitializeComponent();
        }

        void UpdateImage(object sender)
        {
            if (LastPlay == true)
            {
                ((PictureBox)sender).Image = Resources.O_coral;
                LastPlay = false;
                lblPlayer.Text = "PLayer1";
                TurnIcon.Image = Resources.badge_X;

                ((PictureBox)sender).Tag = "O";
            }
            else
            {
                ((PictureBox)sender).Image = Resources.X_dark;
                LastPlay = true;
                lblPlayer.Text = "PLayer2";
                TurnIcon.Image = Resources.badge_O;

                ((PictureBox)sender).Tag = "X";
            }

            ((PictureBox)sender).Enabled = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;

            Counter++;
            UpdateImage(sender);
            UpdateWinner(cell);
        }

        bool Same(PictureBox a, PictureBox b, PictureBox c)
        {
            return a.Tag != null && a.Tag.Equals(b.Tag) && a.Tag.Equals(c.Tag);
        }

        void UpdateWinner(PictureBox LastCell)
        {
            if (Same(guna2PictureBox1, guna2PictureBox2, guna2PictureBox3) ||
               Same(guna2PictureBox4, guna2PictureBox5, guna2PictureBox6)  ||
               Same(guna2PictureBox7, guna2PictureBox8, guna2PictureBox9)  ||
               Same(guna2PictureBox1, guna2PictureBox4, guna2PictureBox7)  ||
               Same(guna2PictureBox2, guna2PictureBox5, guna2PictureBox8)  ||
               Same(guna2PictureBox3, guna2PictureBox6, guna2PictureBox9)  ||
               Same(guna2PictureBox1, guna2PictureBox5, guna2PictureBox9)  ||
               Same(guna2PictureBox3, guna2PictureBox5, guna2PictureBox7))
            {

                lblWinner.Text = LastCell.Tag.Equals("X") ? "~  Player1  ~" : "~  Player2  ~";
                lblPlayer.Text = "Game Over";

                MessageBox.Show("Game over", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DisableAllButtons();

            }
            else if (Counter == 9)
            {
                lblWinner.Text = "~   Draw   ~";
                lblPlayer.Text = "Game Over";

                DisableAllButtons();

                MessageBox.Show("Game over", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void DisableAllButtons()
        {
            guna2PictureBox1.Enabled = false;
            guna2PictureBox2.Enabled = false;
            guna2PictureBox3.Enabled = false;
            guna2PictureBox4.Enabled = false;
            guna2PictureBox5.Enabled = false;
            guna2PictureBox6.Enabled = false;
            guna2PictureBox7.Enabled = false;
            guna2PictureBox8.Enabled = false;
            guna2PictureBox9.Enabled = false;
        }

        void EnableAllButtons()
        {
            guna2PictureBox1.Enabled = true;
            guna2PictureBox2.Enabled = true;
            guna2PictureBox3.Enabled = true;
            guna2PictureBox4.Enabled = true;
            guna2PictureBox5.Enabled = true;
            guna2PictureBox6.Enabled = true;
            guna2PictureBox7.Enabled = true;
            guna2PictureBox8.Enabled = true;
            guna2PictureBox9.Enabled = true;
        }

        void Reset()
        {
            guna2PictureBox1.Image = Resources.Hand_Drawn_Red_Question1;

            guna2PictureBox2.Image = guna2PictureBox1.Image;
            guna2PictureBox3.Image = guna2PictureBox1.Image;
            guna2PictureBox4.Image = guna2PictureBox1.Image;
            guna2PictureBox5.Image = guna2PictureBox1.Image;
            guna2PictureBox6.Image = guna2PictureBox1.Image;
            guna2PictureBox7.Image = guna2PictureBox1.Image;
            guna2PictureBox8.Image = guna2PictureBox1.Image;
            guna2PictureBox9.Image = guna2PictureBox1.Image;

            EnableAllButtons();

            guna2PictureBox1.Tag = null;
            guna2PictureBox2.Tag = null;
            guna2PictureBox3.Tag = null;
            guna2PictureBox4.Tag = null;
            guna2PictureBox5.Tag = null;
            guna2PictureBox6.Tag = null;
            guna2PictureBox7.Tag = null;
            guna2PictureBox8.Tag = null;
            guna2PictureBox9.Tag = null;

            Counter = 0;
            LastPlay = false;
            lblPlayer.Text = "Player1";
            TurnIcon.Image = Resources.badge_X;
            lblWinner.Text = "In Progress";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

    }
}
