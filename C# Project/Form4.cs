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
    public partial class FlappyBird : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        bool gameOver = false;
              
        public FlappyBird()
        {
            InitializeComponent();
            RestartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fbird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            Scores.Text = "Score: " + score;

            if (pipeDown.Left < -150)
            {
                pipeDown.Left = 800;
                score++;
            }
            if (pipeUp.Left < -180)
            {
                pipeUp.Left = 950;
                score++;
            }
            if (fbird.Bounds.IntersectsWith(pipeDown.Bounds) || 
                fbird.Bounds.IntersectsWith(pipeUp.Bounds) || 
                fbird.Bounds.IntersectsWith(ground.Bounds) || 
                fbird.Top < -25)
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 10;
            }
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.Q)
            {
                DialogResult dialogResult = MessageBox.Show("", "Do you want to exit?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    Form frm4 = new Main_Menu();
                    frm4.Show();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }



        }
        private void endGame()
        {
            timer1.Stop();
            Scores.Text = "  Game Over!!!";
            gameOver = true;

            retry.Visible = true;
            retry.Enabled = true;
            quit.Visible = true;
            quit.Enabled = true;
            label1.Visible = true;
            label2.Visible = true;

        }
        private void RestartGame()
        {           
            gameOver = false;
            fbird.Location = new Point(88,102);
            pipeUp.Left = 950;
            pipeDown.Left = 800;

            retry.Visible = false;
            retry.Enabled = false;  
            quit.Visible = false;
            quit.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            
            score = 0;
            pipeSpeed = 8;
            Scores.Text = "Score: 0";
            timer1.Start();

        }      

        private void RestartClickEvent(object sender, EventArgs e)
        {
            RestartGame();
        }


        private void QuitClickEvent(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("", "Do you want to exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form frm4 = new Main_Menu();
                frm4.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void pipeUp_Click(object sender, EventArgs e)
        {

        }
    }
}
