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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            

            if (txt_user.Text == "ITEC21" && txt_pass.Text == "12345")
            {
                this.Hide();
                MessageBox.Show("Welcome to ITEC21");
                Form frm1 = new Main_Menu();
                frm1.Show();

            }

            else if (txt_pass.Text == "12345")
            {
                MessageBox.Show("Please enter used ID");
            }

            else if (txt_user.Text == "ITEC21")
            {
                MessageBox.Show("Please enter your password");
            }

            else if (txt_user.Text == "" && txt_pass.Text == "")
            {
                MessageBox.Show("Please fill up your information");
            }

            else
            {
                MessageBox.Show("Invalid credentials");               
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("", "Do you want to exit?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
