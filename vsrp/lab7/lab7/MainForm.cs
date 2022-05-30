using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class MainForm : Form
    {
        private readonly Medicine _computer;

        public MainForm()
        {
            InitializeComponent();

            _computer = new Medicine();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            var dataForm = new Input(_computer);
            dataForm.Show();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            var showDataForm = new Show(_computer);
            showDataForm.Show();
        }
    }
}
