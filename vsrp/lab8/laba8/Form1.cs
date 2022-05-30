using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace laba8
{
    public partial class MainForm : Form
    {
        private readonly List<Medicine> _medicines = new List<Medicine>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            var ointment = new Ointment();
            var pills = new Pills();

            if (radioButtonPills.Checked)
            {
                var pillsForm = new PillsForm(pills);
                pillsForm.Show();
                _medicines.Add(pills);
            }

            if (!radioButtonOintment.Checked)
            {
                var ointmentForm = new OintmentForm(ointment);
                ointmentForm.Show();
                _medicines.Add(ointment);
            }
        }

        private void buttonShortData_Click(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();

            foreach (var med in _medicines)
            {
                listBoxMedicine.Items.Add(med);
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            var item = (Medicine) listBoxMedicine.SelectedItem;

            MessageBox.Show(item.Show());
        }
    }
}
