using lab8;
using lab8.Forms;
using laba8.Models.Entities;

namespace laba8
{
    public partial class MainForm : Form
    {
        //public event EventHandler OnAdd;

        public delegate void AddDelegate(Medicine item);
        
        public event AddDelegate OnMyAdd;

        private readonly JournalList<Medicine> _medicines = new JournalList<Medicine>();

        public MainForm()
        {          
            InitializeComponent();
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
    }
}
