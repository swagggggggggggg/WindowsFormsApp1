using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string card = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            card = "Quin of diamonds";
            textBox1.Text = card;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            card = "7 of clubs";
            textBox1.Text = card;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            card = "Ace of diamonds";
            textBox1.Text = card;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            card = "King of hearts";
            textBox1.Text = card;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
