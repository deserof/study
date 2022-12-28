using lab8.Models.Entities;

namespace lab8.Forms
{
    public partial class ProductsForm : Form
    {
        private readonly List<Medicine> _medicines = new List<Medicine>();

        public ProductsForm()
        {
            InitializeComponent();

            _medicines.AddRange(Storage.Medicines);

            listBoxMedicine.Items.Clear();

            foreach (var med in _medicines)
            {
                listBoxMedicine.Items.Add(med);
            }

            sortByCustom.Visible = false;
            sortByCustom.Enabled = false;
        }

        private void SortByWhereFuncCondition(Func<Medicine, bool> func)
        {
            foreach (var med in _medicines.Where(func))
            {
                listBoxMedicine.Items.Add(med);
            }
        }

        private void findByYear_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(searchTextBox.Text, out var searchValue))
            {
                return;
            }

            listBoxMedicine.Items.Clear();

            if (radioAll.Checked)
            {
                SortByWhereFuncCondition(med => med.ChangeEntityDateTime == searchValue);
            }

            if (radioPills.Checked)
            {
                SortByWhereFuncCondition(med => med is Pills && med.ChangeEntityDateTime == searchValue);
            }

            if (radioOintments.Checked)
            {
                SortByWhereFuncCondition(med => med is Ointment && med.ChangeEntityDateTime == searchValue);
            }
        }

        private void findByName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                return;
            }

            listBoxMedicine.Items.Clear();

            if (radioAll.Checked)
            {
                SortByWhereFuncCondition(med => med.Title.ToLower().Contains(searchTextBox.Text.ToLower()));
            }

            if (radioPills.Checked)
            {
                SortByWhereFuncCondition(med => med is Pills && med.Title.ToLower().Contains(searchTextBox.Text.ToLower()));
            }

            if (radioOintments.Checked)
            {
                SortByWhereFuncCondition(med => med is Ointment && med.Title.ToLower().Contains(searchTextBox.Text.ToLower()));
            }
        }

        private void findByCountry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                return;
            }

            listBoxMedicine.Items.Clear();

            if (radioAll.Checked)
            {
                SortByWhereFuncCondition(med => med.Country.ToLower().Contains(searchTextBox.Text.ToLower()));
            }

            if (radioPills.Checked)
            {
                SortByWhereFuncCondition(med => med is Pills && med.Country.ToLower().Contains(searchTextBox.Text.ToLower()));
            }

            if (radioOintments.Checked)
            {
                SortByWhereFuncCondition(med => med is Ointment && med.Country.ToLower().Contains(searchTextBox.Text.ToLower()));
            }
        }

        private void findByPrice_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(searchTextBox.Text, out decimal searchValue))
            {
                return;
            }

            listBoxMedicine.Items.Clear();

            if (radioAll.Checked)
            {
                SortByWhereFuncCondition(med => med.PriceWithNds == searchValue);
            }

            if (radioPills.Checked)
            {
                SortByWhereFuncCondition(med => med is Pills && med.PriceWithNds == searchValue);
            }

            if (radioOintments.Checked)
            {
                SortByWhereFuncCondition(med => med is Ointment && med.PriceWithNds == searchValue);
            }
        }

        private void sortByPrice_Click(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();

            if (radioAll.Checked)
            {
                foreach (var item in SortService.SortAllByPrice())
                {
                    listBoxMedicine.Items.Add(item);
                }
            }

            if (radioPills.Checked)
            {
                foreach (var item in SortService.SortPillsByPrice())
                {
                    listBoxMedicine.Items.Add(item);
                }
            }

            if (radioOintments.Checked)
            {
                foreach (var item in SortService.SortOintmentsByPrice())
                {
                    listBoxMedicine.Items.Add(item);
                }
            }
        }

        private void sortByDate_Click(object sender, EventArgs e)
        {
            var customMedColl = new CustomMedicineCollection(Storage.Medicines);
            listBoxMedicine.Items.Clear();
            if (radioAll.Checked)
            {
                foreach (var item in SortService.SortAllByDate(customMedColl))
                {
                    listBoxMedicine.Items.Add(item);
                }
            }

            if (radioPills.Checked)
            {
                foreach (var item in SortService.SortPillsByDate(customMedColl))
                {
                    listBoxMedicine.Items.Add(item);
                }
            }

            if (radioOintments.Checked)
            {
                foreach (var item in SortService.SortOintmentsByDate(customMedColl))
                {
                    listBoxMedicine.Items.Add(item);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();

            foreach (var med in _medicines)
            {
                listBoxMedicine.Items.Add(med);
            }

            radioAll.Checked = true;
            searchTextBox.Clear();
        }

        private void sortByCustom_Click(object sender, EventArgs e)
        {
            var customMedColl = new OintmentCollection(Storage.Ointments);
            listBoxMedicine.Items.Clear();
            if (radioOintments.Checked)
            {
                foreach (var item in SortService.SortOintmentsByTitle(customMedColl))
                {
                    listBoxMedicine.Items.Add(item);
                }

                return;
            }

            var customMedColl2 = new PillsCollection(Storage.Pills);
            if (radioPills.Checked)
            {
                foreach (var item in SortService.SortPillsByQuantity(customMedColl2))
                {
                    listBoxMedicine.Items.Add(item);
                }
            }
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAll.Checked)
            {
                sortByCustom.Visible = false;
                sortByCustom.Enabled = false;
            }
        }

        private void radioPills_CheckedChanged(object sender, EventArgs e)
        {
            sortByCustom.Text = "Сортировка по количеству таблеток";
            sortByCustom.Visible = true;
            sortByCustom.Enabled = true;
        }

        private void radioOintments_CheckedChanged(object sender, EventArgs e)
        {
            sortByCustom.Text = "Сортировка по названию мази";
            sortByCustom.Visible = true;
            sortByCustom.Enabled = true;
        }

        private void listBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetItem() == null)
            {
                return;
            }

            MessageBox.Show(GetItem().Show());
        }

        private Medicine GetItem()
        {
            return (Medicine)listBoxMedicine.SelectedItem;
        }
    }
}
