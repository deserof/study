using System;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        private int _result;

        public Form1()
        {
            InitializeComponent();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(xText.Text, out int x))
            {
                MessageBox.Show("wrong value(s)., Try again");
                return;
            }

            if (!int.TryParse(yText.Text, out int y))
            {
                MessageBox.Show("wrong value(s)., Try again");
                return;
            }

            try
            {
                checked
                {
                    _result = x * y;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("very big value");
                return;
            }


            resultText.Text = _result.ToString();
            Form2 form2 = new Form2(resultText.Text);
            form2.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            xText.Clear();
            yText.Clear();
            resultText.Clear();
        }
    }
}
