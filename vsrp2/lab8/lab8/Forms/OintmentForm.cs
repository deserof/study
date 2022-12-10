using Domain.Enums;
using lab8.Models.Entities;

namespace laba8
{
    public partial class OintmentForm : Form
    {
        private readonly Ointment _ointment;

        public OintmentForm(Ointment ointment)
        {
            InitializeComponent();

            comboBoxType.Items.AddRange(GetDescriptions<OitmentType>().ToArray());
            comboBoxType.SelectedIndex = 0;

            comboBoxMinimalAge.Items.AddRange(GetDescriptions<MinimalAgeType>().ToArray());
            comboBoxMinimalAge.SelectedIndex = 0;

            _ointment = ointment;

            SetPermissions();
        }

        public OintmentForm(Ointment ointment, string qwe)
        {
            InitializeComponent();

            comboBoxType.Items.AddRange(GetDescriptions<OitmentType>().ToArray());
            comboBoxType.SelectedIndex = 0;

            comboBoxMinimalAge.Items.AddRange(GetDescriptions<MinimalAgeType>().ToArray());
            comboBoxMinimalAge.SelectedIndex = 0;

            comboBoxShelfLife.Text = ointment.ShelfLife;
            comboBoxTitle.Text = ointment.Title;
            comboBoxMinimalAge.Text = ointment.MinimalAge.ToString();
            comboBoxCountry.Text = ointment.Country;
            textBoxVolume.Text = ointment.Volume.ToString();
            comboBoxType.Text = ointment.OitmentType;
            priceTextBox.Text = ointment.Price.ToString();
            yearTextBox.Text = ointment._createdEntityDateTime.Year.ToString();

            _ointment = ointment;

            SetPermissions();
        }

        private void SetPermissions()
        {
            if (Storage.CurrentUser.Position == PositionType.Accountant)
            {
                SetPermissionsForAccountant();
            }

            if (Storage.CurrentUser.Position == PositionType.Manager)
            {
                SetPermissionsForSalesDepartment();
            }

            if (Storage.CurrentUser.Position == PositionType.Admin)
            {
                SetPermissionsForAdmin();
            }

            if (Storage.CurrentUser.Position == PositionType.Unknown)
            {
                SetPermissionsForUnknown();
            }
        }

        private void SetPermissionsForUnknown()
        {
        }

        private void SetPermissionsForAdmin()
        {
        }

        private void SetPermissionsForSalesDepartment()
        {
        }

        private void SetPermissionsForAccountant()
        {
            comboBoxShelfLife.Enabled = false;
            comboBoxTitle.Enabled = false;
            comboBoxMinimalAge.Enabled = false;
            comboBoxCountry.Enabled = false;
            textBoxVolume.Enabled = false;
            comboBoxType.Enabled = false;
            priceTextBox.Enabled = true;
            yearTextBox.Enabled = false;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxMinimalAge.Text, out var minimalAge) 
                && (minimalAge == 8 || minimalAge == 14 || minimalAge == 18)
                && int.TryParse(textBoxVolume.Text, out var volume) 
                && volume > 0 && volume < 999
                && decimal.TryParse(priceTextBox.Text, out var price)
                && price > 0
                && int.TryParse(yearTextBox.Text, out var year))
            {
                _ointment.ShelfLife = comboBoxShelfLife.Text;
                _ointment.Title = comboBoxTitle.Text;
                _ointment.MinimalAge = minimalAge;
                _ointment.Country = comboBoxCountry.Text;
                _ointment.Volume = volume;
                _ointment.OitmentType = comboBoxType.Text;
                _ointment.Price = price;
                _ointment.ChangeEntityDateTime = year;
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
