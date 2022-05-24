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
    public partial class DesktopForm : Form
    {
        Desktop Desktop;

        public DesktopForm(Desktop desktop)
        {
            InitializeComponent();

            this.Desktop = desktop;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(comboBoxNumberOfCores.Text, out int numberOfCores))
                && ((int.TryParse(comboBoxNumberOfCores.Text, out int numberOfRam) && numberOfCores > 0 && numberOfCores < 64))
                && (int.TryParse(textBoxBP.Text, out int numberBP) && numberBP > 0 && numberBP < 2000))
            {
                Desktop.GPU = comboBoxGPU.Text;

                Desktop.CPU = comboBoxCPU.Text;

                Desktop.NumberOfCore = numberOfCores;

                Desktop.NumberOfRAM = numberOfRam;

                Desktop.PowerBlock = numberBP;

                Desktop.TypeBody = comboBoxTypeBody.Text;
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
