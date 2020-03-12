using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int tercih = 0, bottercih = 0, bot1tercih = 0, bot2tercih;
        int kalansure=10;
        Random boto = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label12.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label12.Visible = false;
            label13.Visible = false;

            bottercih = boto.Next(1, 4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tercih = 1;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            if (bottercih == 1)
            { 
                label5.Visible=true;
                pictureBox6.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;

            }
            else if (bottercih == 2)
            {
                label4.Visible = true;
                pictureBox5.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;
            }
            else if (bottercih == 3)
            {
                label3.Visible = true;
                pictureBox4.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            if (bot1tercih==1&&bot2tercih==1)
            {
                pictureBox1.Visible = true;
                pictureBox6.Visible = true;
                label10.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 1 && bot2tercih == 2)
            {
                pictureBox1.Visible = true;
                pictureBox5.Visible = true;
                label9.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 1 && bot2tercih == 3)
            {
                pictureBox1.Visible = true;
                pictureBox4.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 2 && bot2tercih == 1)
            {
                pictureBox2.Visible = true;
                pictureBox6.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 2 && bot2tercih == 2)
            {
                pictureBox2.Visible = true;
                pictureBox5.Visible = true;
                label10.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 2 && bot2tercih == 3)
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
                label9.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 3 && bot2tercih == 1)
            {
                pictureBox3.Visible = true;
                pictureBox6.Visible = true;
                label9.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 3 && bot2tercih == 2)
            {
                pictureBox3.Visible = true;
                pictureBox5.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 3 && bot2tercih == 3)
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label10.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            if (bot1tercih == 1 && bot2tercih == 1)
            {
                pictureBox1.Visible = true;
                pictureBox6.Visible = true;
                label10.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 2 && bot2tercih == 1)
            {
                pictureBox1.Visible = true;
                pictureBox5.Visible = true;
                label9.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 3 && bot2tercih == 1)
            {
                pictureBox1.Visible = true;
                pictureBox4.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 1 && bot2tercih == 2)
            {
                pictureBox2.Visible = true;
                pictureBox6.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 2 && bot2tercih == 2)
            {
                pictureBox2.Visible = true;
                pictureBox5.Visible = true;
                label10.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 3 && bot2tercih == 2)
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
                label9.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 1 && bot2tercih == 3)
            {
                pictureBox3.Visible = true;
                pictureBox6.Visible = true;
                label9.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 2 && bot2tercih == 3)
            {
                pictureBox3.Visible = true;
                pictureBox5.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
            else if (bot1tercih == 3 && bot2tercih == 3)
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label10.Visible = true;
                button2.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berkcan Ciboğlu\nxTiXi\nİletişim:berkcan112233@gmail.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tercih = 2;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            if (bottercih == 1)
            {
                label3.Visible = true;
                pictureBox6.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;
            }
            else if (bottercih == 2)
            {
                label5.Visible = true;
                pictureBox5.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;
            }
            else if (bottercih == 3)
            {
                label4.Visible = true;
                pictureBox4.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label12.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            button3.Visible = true;
            button4.Visible = true;

            bot1tercih = boto.Next(1, 4);
            bot2tercih = boto.Next(1, 4);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tercih = 3;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            if (bottercih == 1)
            {
                label4.Visible = true;
                pictureBox6.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;
            }
            else if (bottercih == 2)
            {
                label3.Visible = true;
                pictureBox5.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;
            }
            else if (bottercih == 3)
            {
                label5.Visible = true;
                pictureBox4.Visible = true;
                button1.Text = "Tekrar Tek Kişilik Oyna";
                button1.Visible = true;
                button2.Text = "Tekrar İki Kişilik Oyna";
                button2.Visible = true;
            }
        }
    }
}
