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
           
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 20;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left += -20;
            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top += -20;
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += 20;
            }
        }
    }
}
