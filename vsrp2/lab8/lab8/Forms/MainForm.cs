using Domain.Enums;
using lab8;
using lab8.Models.Entities;

namespace laba8
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly Journal<Medicine> _journal = new Journal<Medicine>();

        private readonly List<Medicine> _medicines = new List<Medicine>();

        private readonly Listener _listener = new Listener();

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();

            _medicines.AddRange(Storage.Medicines);

            SetPermissions();

            _journal.OnSell += _listener.l_OnSell;
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

        private void SetPermissionsForAccountant()
        {
            buttonEnterData.Enabled = false;
            radioButtonOintment.Enabled = false;
            radioButtonPills.Enabled = false;
            сopyButton.Enabled = false;
            sellButton.Enabled = false;
            textBoxEnterPRice.Enabled = false;
            button2.Enabled = true;
            button1.Enabled = true;
        }

        private void SetPermissionsForSalesDepartment()
        {
            buttonEnterData.Enabled = true;
            radioButtonOintment.Enabled = true;
            radioButtonPills.Enabled = true;
            сopyButton.Enabled = false;
            sellButton.Enabled = true;
            textBoxEnterPRice.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void SetPermissionsForAdmin()
        {
            buttonEnterData.Enabled = true;
            radioButtonOintment.Enabled = true;
            radioButtonPills.Enabled = true;
            сopyButton.Enabled = true;
            sellButton.Enabled = true;
            textBoxEnterPRice.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            changeButton.Enabled = true;
        }

        private void SetPermissionsForUnknown()
        {
            buttonEnterData.Enabled = false;
            radioButtonOintment.Enabled = false;
            radioButtonPills.Enabled = false;
            сopyButton.Enabled = false;
            sellButton.Enabled = false;
            textBoxEnterPRice.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            changeButton.Enabled = false;
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            if (radioButtonPills.Checked)
            {
                var pills = new Pills();
                var pillsForm = new PillsForm(pills);
                pillsForm.Show();
                _medicines.Add(pills);
                var wr = _serviceProvider.GetRequiredService<IWriterService>();
                wr.Write(_medicines, "..\\..\\..\\Products.json");
                return;
            }

            if (radioButtonOintment.Checked)
            {
                var ointment = new Ointment();
                var ointmentForm = new OintmentForm(ointment);
                ointmentForm.Show();
                _medicines.Add(ointment);
                var wr = _serviceProvider.GetRequiredService<IWriterService>();
                wr.Write(_medicines, "..\\..\\..\\Products.json");
            }
        }

        private void buttonShortData_Click(object sender, EventArgs e)
        {
            changeButton.Enabled = true;
            buttonEnterData.Enabled = true;
            sellButton.Enabled = true;
            textBoxEnterPRice.Enabled = true;
            SetPermissions();
            if (Storage.CurrentUser.Position == PositionType.Accountant)
            {
                SetPermissionsForAccountant();
            }

            listBoxMedicine.Items.Clear();

            foreach (var med in _medicines.Where(med => !med.IsSold))
            {
                listBoxMedicine.Items.Add(med);
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            if (listBoxMedicine.SelectedIndex == -1)
            {
                return;
            }

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

        private void сopyButton_Click(object sender, EventArgs e)
        {
            var item = listBoxMedicine.SelectedItem;

            if (item is null)
            {
                return;
            }


            if (item is Ointment ointment)
            {
                var copiedItem = new Ointment(ointment);
                _medicines.Add(copiedItem);
                listBoxMedicine.Items.Add(copiedItem);
            }

            if (item is Pills pills)
            {
                var copiedItem = new Pills(pills);
                _medicines.Add(copiedItem);
                listBoxMedicine.Items.Add(copiedItem);
            }
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        Application.Exit();
        //    }
        //}

        private void SellButton_Click(object sender, EventArgs e)
        {
            Medicine selectedMed = (Medicine)listBoxMedicine.SelectedItem;

            if (selectedMed is null)
            {
                return;
            }

            decimal.TryParse(textBoxEnterPRice.Text, out decimal money);

            if (selectedMed.PriceWithNds > money)
            {
                MessageBox.Show("не хватает денег");
                return;
            }

            selectedMed.Sell();

            if (selectedMed.IsSold)
            {
                var index = listBoxMedicine.SelectedIndex;
                _journal.Sell((Medicine)listBoxMedicine.Items[index]);
                listBoxMedicine.Items.RemoveAt(index);
            }

            var wr = _serviceProvider.GetRequiredService<IWriterService>();
            wr.Write(_medicines, "..\\..\\..\\Products.json");

            textBoxEnterPRice.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm userForm = new(_serviceProvider);

            userForm.ShowDialog();

            SetPermissions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeButton.Enabled = false;
            buttonEnterData.Enabled = false;
            sellButton.Enabled = false;
            textBoxEnterPRice.Enabled = false;
            SetPermissions();
            listBoxMedicine.Items.Clear();

            foreach (var med in _medicines.Where(med => med.IsSold))
            {
                listBoxMedicine.Items.Add(med);
            }
        }

        private void formSearch_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            if (listBoxMedicine.SelectedIndex < 0)
            {
                return;
            }

            if (listBoxMedicine.SelectedItem is Ointment ointment)
            {
                var oinmentForm = new OintmentForm(ointment, "edit");
                oinmentForm.ShowDialog();
            }

            if (listBoxMedicine.SelectedItem is Pills pills)
            {
                var pillsForm = new PillsForm(pills, "edit");
                pillsForm.ShowDialog();
            }

            listBoxMedicine.Items.Clear();

            foreach (var med in _medicines.Where(med => !med.IsSold))
            {
                listBoxMedicine.Items.Add(med);
            }
        }
    }
}
