using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class DataForm : Form
    {
        private readonly Medicine _medicine;

        public DataForm(Medicine medicine)
            : this()
        {
            _medicine = medicine;
        }

        public DataForm()
        {
            InitializeComponent();

            comboBoxCountry.Items.AddRange(new object[] { "Germany", "Belarus", "Russia", "India" });
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            bool isCorrect = CheckInput();

            if (isCorrect)
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
                    MessageBox.Show("error input");
                    return;
                }

                _medicine.Title = textBoxNumberOfTablets.Text;
                _medicine.ShelfLife = textBoxShelfLife.Text;
                labelError.Visible = false;

                Close();
            }
        }

        private bool CheckInput()
        {
            var isCorrect = false;
            var selectedItem = comboBoxCountry.SelectedItem;

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
