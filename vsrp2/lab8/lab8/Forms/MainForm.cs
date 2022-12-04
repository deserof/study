using lab8.Models.Entities;
using Microsoft.Extensions.DependencyInjection;

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


            _medicines.AddRange(Storage.Medicines.Where(x=> !x.IsSold));

            //Listener.l_OnMyAddMedicine()
            //_medicines.OnAdd += new EventHandler(JournalList<Medicine>.l_OnAdd);
            //_medicines.OnDelete += new EventHandler(JournalList<Medicine>.l_OnDelete);
            //_medicines.OnChange += new EventHandler(JournalList<Medicine>.l_OnChange);
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            if (radioButtonPills.Checked)
            {
                var pills = new Pills();
                var pillsForm = new PillsForm(pills);
                pillsForm.Show();
                _medicines.Add(pills);
                return;
            }

            if (radioButtonOintment.Checked)
            {
                var ointment = new Ointment();
                var ointmentForm = new OintmentForm(ointment);
                ointmentForm.Show();
                _medicines.Add(ointment);
            }
        }

        private void buttonShortData_Click(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();

            foreach (var med in _medicines)
            {
                listBoxMedicine.Items.Add(med);
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicine selectedMed = (Medicine)listBoxMedicine.SelectedItem;

            if (selectedMed is null)
            {
                return;
            }

            selectedMed.Sell();

            if (selectedMed.IsSold)
            {
                var index = listBoxMedicine.SelectedIndex;
                listBoxMedicine.Items.RemoveAt(index);
            }

            var wr = _serviceProvider.GetRequiredService<IWriterService>();
            wr.Write(Storage.Medicines, "..\\..\\..\\Products.json");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm userForm = new(_serviceProvider);

            userForm.ShowDialog();
        }
    }
}
