using lab2.Models.Entities;
using lab2.Models.Enums;
using lab2.Storage;
using static lab2.Extensions.EnumExtension;

namespace lab2
{
    public partial class EnterDataForm : Form
    {
        public EnterDataForm()
        {
            InitializeComponent();
            validLabel.Visible = false;
            constructionStatusComboBox.Items.AddRange(GetDescriptions<ConstructionStatusType>().ToArray());
            constructionStatusComboBox.SelectedIndex = 0;
            appartmentHouseRadioButton.Checked = true;
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

            var residentalBuilding = new ResidentialBuilding();

            if (appartmentHouseRadioButton.Checked)
            {
                residentalBuilding = new ApartmentHouse
                {
                    Address = addressTextBox.Text,
                    ConstructionStatusType = constructionStatusComboBox.Text,
                    Entrances = Convert.ToInt32(entrancesTextBox.Text),
                    Floors = Convert.ToInt32(floorsTextBox.Text)
                };
            }

            if (cottageRadioButton.Checked)
            {
                residentalBuilding = new Cottage
                {
                    Address = addressTextBox.Text,
                    ConstructionStatusType = constructionStatusComboBox.Text,
                    Entrances = Convert.ToInt32(entrancesTextBox.Text),
                    Floors = Convert.ToInt32(floorsTextBox.Text)
                };
            }

            EntitiesStorage.ResidentialBuildings.Add(residentalBuilding);

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
