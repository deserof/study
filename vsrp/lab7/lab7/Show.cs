using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Show : Form
    {
        public Show(Medicine medicine)
        {
            InitializeComponent();

            labelNumberOfTablets.Text = $"Количество таблеток:{medicine.NumberOfTablets}";
            labelTitle.Text = $"Название:{medicine.Title}";
            labelCountry.Text = $"Страна производитель:{medicine.Country}";
            labelShelfLife.Text = $"Срок годности:{medicine.ShelfLife}";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
