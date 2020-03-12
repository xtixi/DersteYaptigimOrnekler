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
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Left += 20;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Top += -20;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Left += -20;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Top += 20;
        }
    }
}
