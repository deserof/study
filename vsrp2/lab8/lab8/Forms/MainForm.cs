using Domain.Enums;
using lab8.Models.Entities;

namespace laba8
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        //public event EventHandler OnAdd;

        public delegate void AddDelegate(Medicine item);

        public event AddDelegate OnMyAdd;

        private readonly JournalList<Medicine> _medicines = new JournalList<Medicine>();

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();

            _medicines.AddRange(Storage.Medicines);

            if (Storage.CurrentUser.Position == PositionType.Accountant)
            {
                SetPermissionsForAccountant();
            }

            //Listener.l_OnMyAddMedicine()
            //_medicines.OnAdd += new EventHandler(JournalList<Medicine>.l_OnAdd);
            //_medicines.OnDelete += new EventHandler(JournalList<Medicine>.l_OnDelete);
            //_medicines.OnChange += new EventHandler(JournalList<Medicine>.l_OnChange);
        }

        private void SetPermissionsForAccountant()
        {
            buttonEnterData.Enabled = false;
            radioButtonOintment.Enabled = false;
            radioButtonOintment.Checked = false;
            сopyButton.Enabled = false;
            formSearch.Enabled = false;
            sellButton.Enabled = false;
            textBoxEnterPRice.Enabled = false;
        }

        private void SetPermissionsForSalesDepartment()
        {

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeButton.Enabled = false;
            buttonEnterData.Enabled = false;
            sellButton.Enabled = false;
            textBoxEnterPRice.Enabled = false;

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
