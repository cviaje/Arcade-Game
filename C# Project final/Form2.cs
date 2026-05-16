using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();         
        }

        private void GuessingGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to Guessing Game");
            Form frm2 = new GuessingGame();
            frm2.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("", "Do you want to exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form frm2 = new Form1();
                frm2.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }

        private void FlappyBird_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to FLAPPY BIRD");
            Form frm2 = new FlappyBird();
            frm2.Show();
        }

        private void timerrrr(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
            if(progressBar1.Value == 100)
            {
                GuessingGame.Visible = true;
                FlappyBird1.Visible = true;
                TicTactoe.Visible = true;
                Credits.Visible = true;
                Exit.Visible = true;
                progressBar1.Visible = false;
                label2.Visible = false;
                label1.Visible = true;

            }
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            GuessingGame.Visible = false;
            FlappyBird1.Visible = false;
            TicTactoe.Visible = false;
            Credits.Visible = false;
            Exit.Visible = false;
            label1.Visible = false;

        }

        private void TicTactoe_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to Tic Tac Toe");
            Form frm2 = new Tic_Tac_Toe();
            frm2.Show();
        }
    }
}
