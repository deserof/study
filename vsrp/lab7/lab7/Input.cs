using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Input : Form
    {
        private readonly Medicine _medicine;


        public Input()
        {
            InitializeComponent();

            comboBoxCountry.Items.AddRange(new object[] { "Germany", "Belarus", "Russia", "India" });
        }

        public Input(Medicine medicine)
            : this()
        {
            _medicine = medicine;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if (!IsCorrect())
            {
                labelError.Visible = true;
            }
            else
            {
                _medicine.Country = comboBoxCountry.Text;

                if(int.TryParse(textBoxNumberOfTablets.Text, out int numOfT))
                {
                    _medicine.NumberOfTablets = numOfT;
                }
                else
                {
                    MessageBox.Show("error");
                    return;
                }

                _medicine.Title = textBoxTitle.Text;
                _medicine.ShelfLife = textBoxShelfLife.Text;
                labelError.Visible = false;

                Close();
            }
        }

        private bool IsCorrect()
        {
            var selectedItem = comboBoxCountry.SelectedItem;

            if (selectedItem is null
                || string.IsNullOrEmpty(textBoxTitle.Text)
                || string.IsNullOrEmpty(textBoxNumberOfTablets.Text)
                || string.IsNullOrEmpty(textBoxShelfLife.Text))
            {
                return false;
            }

            return true;
        }
    }
}
