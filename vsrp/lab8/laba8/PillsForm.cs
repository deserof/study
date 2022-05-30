using System;
using System.Windows.Forms;

namespace laba8
{
    public partial class PillsForm : Form
    {
        private readonly Pills _pills;

        public PillsForm(Pills pills)
        {
            InitializeComponent();

            _pills = pills;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxMinimalAge.Text, out int minimalAge) 
                && (minimalAge == 6 || minimalAge == 10 || minimalAge == 18)
                && int.TryParse(textBoxQuantity.Text, out int quantity) 
                && quantity > 0 && quantity < 50)
            {
                _pills.ShelfLife = comboBoxShelfLife.Text;
                _pills.Title = comboBoxTitle.Text;
                _pills.MinimalAge = minimalAge;
                _pills.Country = comboBoxCountry.Text;
                _pills.Color = textBoxColor.Text;
                _pills.Quantity = quantity;
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
