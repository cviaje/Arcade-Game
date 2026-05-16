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
    public partial class GuessingGame : Form
    {
      
            Random random = new Random();
            int number = 0;
            int guesses = 0;
            Int32 i;

    
            public GuessingGame()
            {
               InitializeComponent();
               LoadQuestion();
            }
            private void LoadQuestion()
            {
               number = random.Next(1, 100);
            }   
        private void Check_Click(object sender, EventArgs e)
        {
            if (txt_Enternumber.Text == "")
            {
                MessageBox.Show("Please Enter Your Guess Number");
                i = 0;
            }
            else
            {
                i = Int32.Parse(txt_Enternumber.Text);
                guesses += 1;
                lblGuessed.Text = "You guessed: " + guesses + " times";
            }
            if (i == 0)
            {
                txt_Enternumber.Text = "";
            }
            else if (i > number)
            {
                MessageBox.Show("Your guess was too high");
                txt_Enternumber.Text = "";
            }
            else if (i < number)
            {
                MessageBox.Show("Your guess was too low");
                txt_Enternumber.Text = "";
            }
            else
            {
                MessageBox.Show("Nice, You guessed it. Try another!");
                LoadQuestion();
                txt_Enternumber.Text = "";
                guesses = 0;

            }          
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("", "Do you want to exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form frm3 = new Main_Menu();
                frm3.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }
    }
}
