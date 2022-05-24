using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class MainForm : Form
    {
        private Medicine Computer;

        public MainForm()
        {
            InitializeComponent();

            Computer = new Medicine();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {           
            DataForm dataForm = new DataForm(Computer);

            dataForm.Show();
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {          
            ShowDataForm showDataForm = new ShowDataForm(Computer);

            showDataForm.Show();
        }
    }
}
