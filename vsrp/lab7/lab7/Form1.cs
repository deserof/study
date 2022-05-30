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

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            var dataForm = new DataForm(_computer);
            dataForm.Show();
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            var showDataForm = new ShowDataForm(_computer);
            showDataForm.Show();
        }
    }
}
