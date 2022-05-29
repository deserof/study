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
        List<Medicine> medicines = new List<Medicine>();      

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            Ointment ointment = new Ointment();

            Pills pills = new Pills();

            if (radioButtonPills.Checked)
            {
                PillsForm pillsForm = new PillsForm(pills);

                pillsForm.Show();

                medicines.Add(pills);              
            }
            else if (radioButtonOintment.Checked)
            {
                OintmentForm ointmentForm = new OintmentForm(ointment);

                ointmentForm.Show();

                medicines.Add(ointment);                
            }          
        }

        private void buttonShortData_Click(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();

            for (int i = 0; i < medicines.Count; i++)
            {
                listBoxMedicine.Items.Add(medicines[i]);
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            if (!(listBoxMedicine.SelectedItem is  Pills))
            {
                Ointment selectedMedicine = (Ointment)listBoxMedicine.SelectedItem;

                MessageBox.Show(selectedMedicine.Show());
            }
            else
            {
                Pills selectedMedicine = (Pills)listBoxMedicine.SelectedItem;

                MessageBox.Show(selectedMedicine.Show());
            }
        }
    }
}
