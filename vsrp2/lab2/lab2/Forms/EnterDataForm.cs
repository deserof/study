using lab2.Models.Entities;
using lab2.Models.Enums;
using lab2.Storage;
using static lab2.Extensions.EnumExtension;

namespace lab2
{
    public partial class EnterDataForm : Form
    {
        private ResidentialBuilding _residentialBuilding;

        public EnterDataForm()
        {
            InitializeComponent();
            validLabel.Visible = false;
            constructionStatusComboBox.Items.AddRange(GetDescriptions<ConstructionStatusType>().ToArray());
            constructionStatusComboBox.SelectedIndex = 0;
        }

        public EnterDataForm(ResidentialBuilding residentialBuilding)
            : this()
        {
            _residentialBuilding = residentialBuilding;


            if (_residentialBuilding is ApartmentHouse)
            {
                windowsTextBox.ReadOnly = true;
                roomsTextBox.ReadOnly = true;
                roomsTextBox.ReadOnly = true;
            }
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyOrDefaultString(addressTextBox, entrancesTextBox, floorsTextBox) ||
                IsNotNumber(entrancesTextBox, floorsTextBox, windowsTextBox, roomsTextBox) ||
                IsNegativeNumber(entrancesTextBox, floorsTextBox, windowsTextBox, roomsTextBox))
            {
                validLabel.Visible = true;

                return;
            }

            if (_residentialBuilding is ApartmentHouse)
            {
                ApartmentHouse cottage = (ApartmentHouse)_residentialBuilding;

                cottage.Address = addressTextBox.Text;
                cottage.ConstructionStatusType = constructionStatusComboBox.Text;
                cottage.Entrances = Convert.ToInt32(entrancesTextBox.Text);
                cottage.Floors = Convert.ToInt32(floorsTextBox.Text);
            }

            if (_residentialBuilding is Cottage)
            {
                Cottage cottage = (Cottage)_residentialBuilding;

                cottage.Address = addressTextBox.Text;
                cottage.ConstructionStatusType = constructionStatusComboBox.Text;
                cottage.Entrances = Convert.ToInt32(entrancesTextBox.Text);
                cottage.Floors = Convert.ToInt32(floorsTextBox.Text);
                cottage.Windows = Convert.ToInt32(windowsTextBox.Text);
                cottage.Rooms = Convert.ToInt32(roomsTextBox.Text);
            }

            EntitiesStorage.ResidentialBuildings.Add(_residentialBuilding);

            Close();            
        }

        private bool IsEmptyOrDefaultString(params TextBox[] values)
        {
            foreach (var value in values)
            {
                if (value.ReadOnly)
                {
                    continue;
                }

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
                if (value.ReadOnly)
                {
                    continue;
                }

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
                if (value.ReadOnly)
                {
                    continue;
                }

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
