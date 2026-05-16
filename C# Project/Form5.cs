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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            l9.Visible = true;
            l10.Visible = true;
            l11.Visible = true;
            l12.Visible = true;
            l13.Visible = true;
            l14.Visible = true;
            l15.Visible = true;
            l16.Visible = true;
            p4.Visible = true;
            p5.Visible = true;
            p6.Visible = true;
            bg.Visible = true;

            retbtn.Visible = true;

            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;

            infobg.Visible = true;

            Caila.Visible = false;
            Christian.Visible = false;
            EXIT.Visible = true;
        }

        private void Christian_Click(object sender, EventArgs e)
        {
            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;
            l5.Visible = true;
            l6.Visible = true;
            l7.Visible = true;
            l8.Visible = true;
            p1.Visible = true;
            p2.Visible = true;
            p3.Visible = true;
            bg.Visible = true; 

            retbtn.Visible = true;

            l9.Visible = false;
            l10.Visible = false;
            l11.Visible = false;
            l12.Visible = false;
            l13.Visible = false;
            l14.Visible = false;
            l15.Visible = false;
            l16.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p6.Visible = false;

            infobg.Visible = true;

            Caila.Visible = false;
            Christian.Visible = false;
            EXIT.Visible = true;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("", "Do you want to exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form frm5 = new Main_Menu();
                frm5.Show();
            }
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            Caila.Visible = true;
            Christian.Visible = true;
            bg.Visible = false;
            infobg.Visible = false;

            //Cristian
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;

            //Caila
            l9.Visible = false;
            l10.Visible = false;
            l11.Visible = false;
            l12.Visible = false;
            l13.Visible = false;
            l14.Visible = false;
            l15.Visible = false;
            l16.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p6.Visible = false;

            retbtn.Visible = false;
        }

        private void retbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm5 = new Credits();
            frm5.Show();
        }
    }
}
