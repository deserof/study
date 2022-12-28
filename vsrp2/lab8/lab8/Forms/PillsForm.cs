using Domain.Enums;
using lab8;
using lab8.Models.Entities;
using System.Diagnostics;
using System.Windows.Forms;

namespace laba8
{
    public partial class PillsForm : Form
    {
        private readonly Pills _pills;
        private string _op;
        private readonly Journal<Medicine> _journal = new Journal<Medicine>();
        private readonly Listener _listener = new Listener();
        public PillsForm(Pills pills)
        {
            InitializeComponent();

            comboBoxMinimalAge.Items.AddRange(GetDescriptions<MinimalAgeType>().ToArray());
            comboBoxMinimalAge.SelectedIndex = 0;

            _pills = pills;

            SetPermissions();

            _journal.OnChange += _listener.l_OnAdd;
        }

        public PillsForm(Pills pills, string qwe)
        {
            InitializeComponent();
            _op = qwe;
            comboBoxMinimalAge.Items.AddRange(GetDescriptions<MinimalAgeType>().ToArray());
            comboBoxMinimalAge.SelectedIndex = 0;

            comboBoxShelfLife.Text = pills.ShelfLife;
            comboBoxTitle.Text = pills.Title;
            comboBoxMinimalAge.Text = pills.MinimalAge.ToString();
            comboBoxCountry.Text = pills.Country;
            textBoxColor.Text = pills.Color;
            textBoxQuantity.Text = pills.Quantity.ToString();
            priceTextBox.Text = pills.Price.ToString();
            yearTextBox.Text = pills.ChangeEntityDateTime.ToString();

            _pills = pills;

            SetPermissions();

            _journal.OnChange += _listener.l_OnChange;
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
            textBoxColor.Enabled = false;
            textBoxQuantity.Enabled = false;
            priceTextBox.Enabled = true;
            yearTextBox.Enabled = false;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxMinimalAge.Text, out var minimalAge) 
                && (minimalAge == 8 || minimalAge == 14 || minimalAge == 18)
                && int.TryParse(textBoxQuantity.Text, out var quantity) 
                && quantity > 0 && quantity < 50
                && decimal.TryParse(priceTextBox.Text, out var price)
                && price > 0
                && int.TryParse(yearTextBox.Text, out var year))
            {
                _pills.ShelfLife = comboBoxShelfLife.Text;
                _pills.Title = comboBoxTitle.Text;
                _pills.MinimalAge = minimalAge;
                _pills.Country = comboBoxCountry.Text;
                _pills.Color = textBoxColor.Text;
                _pills.Quantity = quantity;
                _pills.Price = price;
                _pills.ChangeEntityDateTime = year;
            }
            else
            {
                MessageBox.Show("Введите корректные значения");

                return;
            }

            Close();

            if (string.IsNullOrEmpty(_op)) _journal.Add(_pills);

            _journal.Change(_pills);
        }
    }
}
