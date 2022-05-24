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
    public partial class NotebookForm : Form
    {
        Notebook Notebook;

        public NotebookForm(Notebook notebook)
        {
            InitializeComponent();

            this.Notebook = notebook;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(comboBoxNumberOfCores.Text, out int numberOfCores))
                &&((int.TryParse(comboBoxNumberOfCores.Text, out int numberOfRam) && numberOfCores > 0 && numberOfCores < 64))
                &&(int.TryParse(textBoxWorkHours.Text, out int numberWorkHours) && numberWorkHours > 0 && numberWorkHours < 15))
            {
                Notebook.GPU = comboBoxGPU.Text;

                Notebook.CPU = comboBoxCPU.Text;

                Notebook.NumberOfCore = numberOfCores;

                Notebook.NumberOfRAM = numberOfRam;

                Notebook.WorkHours = numberWorkHours;

                Notebook.TypeBattery = comboBoxBattery.Text;
            }
            else
            {
                MessageBox.Show("Введите корректные значения");

                return;
            }
          
            Close();
        }
    }
}
