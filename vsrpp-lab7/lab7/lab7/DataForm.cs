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
    public partial class DataForm : Form
    {
        Medicine medicine;

        public DataForm(Medicine medicine) :this()
        {
            this.medicine = medicine;
        }

        public DataForm()
        {            
            InitializeComponent();

            comboBoxCountry.Items.AddRange(new string[] { "Germany", "Belarus", "Russia", "India" });
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            bool isCorrect = isCorrectData();

            if (isCorrect)
            {
                labelError.Visible = true;
            }
            else
            {
                medicine.Country = comboBoxCountry.Text;

                medicine.NumberOfTablets = int.Parse(textBoxNumberOfTablets.Text);

                medicine.Title = textBoxNumberOfTablets.Text;

                medicine.ShelfLife = textBoxShelfLife.Text;

                labelError.Visible = false;

                Close();
            }        
        }

        private bool isCorrectData()
        {
            bool isCorrect = false;

            Object selectedItem = comboBoxCountry.SelectedItem;

            if (selectedItem is null
                || string.IsNullOrEmpty(textBoxTitle.Text)
                || string.IsNullOrEmpty(textBoxNumberOfTablets.Text)
                || string.IsNullOrEmpty(textBoxShelfLife.Text))
            {
                isCorrect = true;
            }

            return isCorrect;
        }
    }
}
