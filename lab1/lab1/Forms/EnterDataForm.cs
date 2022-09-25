using lab1.Models;
using lab1.Storage;
using static lab1.Extensions.EnumExtension;

namespace lab1
{
    public partial class EnterDataForm : Form
    {
        public EnterDataForm()
        {
            InitializeComponent();
            validLabel.Visible = false;
            constructionStatusComboBox.Items.AddRange(GetDescriptions<ConstructionStatusType>().ToArray());
            constructionStatusComboBox.SelectedIndex = 0;
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyOrDefaultString(addressTextBox, entrancesTextBox, floorsTextBox) ||
                IsNotNumber(entrancesTextBox, floorsTextBox) ||
                IsNegativeNumber(entrancesTextBox, floorsTextBox))
            {
                validLabel.Visible = true;

                return;
            }

            var residentalBuilding = new ResidentialBuilding
            {
                Address = addressTextBox.Text,
                ConstructionStatusType = constructionStatusComboBox.Text,
                Entrances = Convert.ToInt32(entrancesTextBox.Text),
                Floors = Convert.ToInt32(floorsTextBox.Text)
            };

            EntitiesStorage.ResidentialBuilding = residentalBuilding;

            Close();            
        }

        private bool IsEmptyOrDefaultString(params TextBox[] values)
        {
            foreach (var value in values)
            {
                if (value.Text == string.Empty)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsNotNumber(params TextBox[] values)
        {
            foreach (var value in values)
            {
                if (!int.TryParse(value.Text, out _))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsNegativeNumber(params TextBox[] values)
        {
            foreach (var value in values)
            {
                if (int.TryParse(value.Text, out int number))
                {
                    if (number < 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
