using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab2zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "test";
        }

        private void btnred_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void btnblue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void btngreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnyellow_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void btnwhite_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = btn3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Green;
        }
    }
}
