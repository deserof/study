namespace laba8
{
    public partial class PillsForm : Form
    {
        private readonly Pills _pills;

        public PillsForm(Pills pills)
        {
            InitializeComponent();

            comboBoxMinimalAge.Items.AddRange(GetDescriptions<MinimalAgeType>().ToArray());
            comboBoxMinimalAge.SelectedIndex = 0;

            _pills = pills;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxMinimalAge.Text, out var minimalAge) 
                && (minimalAge == 6 || minimalAge == 10 || minimalAge == 18)
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
        }
    }
}
