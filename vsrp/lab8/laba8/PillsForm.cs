using System;
using System.Windows.Forms;

namespace laba8
{
    public partial class PillsForm : Form
    {
        Pills pills;

        public PillsForm(Pills pills)
        {
            InitializeComponent();

            this.pills = pills;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(comboBoxMinimalAge.Text, out int minimalAge) && (minimalAge == 6 || minimalAge == 10 || minimalAge == 18))
                && (int.TryParse(textBoxQuantity.Text, out int quaintity) && quaintity > 0 && quaintity < 50))
            {
                pills.ShelfLife = comboBoxShelfLife.Text;

                pills.Title = comboBoxTitle.Text;

                pills.MinimalAge = minimalAge;

                pills.Country = comboBoxCountry.Text;

                pills.Color = textBoxColor.Text;

                pills.Quantity = quaintity;
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
