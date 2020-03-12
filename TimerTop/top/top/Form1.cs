using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace top
{
    public partial class Form1 : Form
    {

        int a=0;
        


        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 200;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            a = 1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            a = 3;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            a = 2;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            a = 4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(a==1)
            { 
                pictureBox1.Left += 20;
            }
            else if(a==2)
            {
                pictureBox1.Left += -20;
            }
            else if (a == 3)
            {
                pictureBox1.Top += -20;
            }
            else if (a == 4)
            {
                pictureBox1.Top += 20;
            }
        }

        private void dur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
