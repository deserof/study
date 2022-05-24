using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba8
{
    public partial class MainForm : Form
    {
        List<Computer> computers = new List<Computer>();      

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();

            Desktop desktop = new Desktop();

            if (radioButtonNotebook.Checked == true)
            {
                NotebookForm notebookForm = new NotebookForm(notebook);               

                notebookForm.Show();

                computers.Add(notebook);              
            }
            else if (radioButtonDesktop.Checked == true)
            {
                DesktopForm desktopForm = new DesktopForm(desktop);

                desktopForm.Show();

                computers.Add(desktop);                
            }          
        }

        private void buttonShortData_Click(object sender, EventArgs e)
        {
            listBoxComputer.Items.Clear();

            for (int i = 0; i < computers.Count; i++)
            {
                listBoxComputer.Items.Add(computers[i]);
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            if (listBoxComputer.SelectedItem is Desktop)
            {
                Desktop selectedComputer = (Desktop)listBoxComputer.SelectedItem;

                MessageBox.Show(selectedComputer.Show());
            }
            else
            {
                Notebook selectedComputer = (Notebook)listBoxComputer.SelectedItem;

                MessageBox.Show(selectedComputer.Show());
            }
        }
    }
}
