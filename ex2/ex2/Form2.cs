using System;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form2 : Form
    {
        public Form2(string result)
        {
            InitializeComponent();
            resultText.Text = result;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
