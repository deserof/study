using laba8.Models.Entities;

namespace laba8
{
    public partial class MainForm : Form
    {
        public event EventHandler OnAdd;

        private readonly JournalList<Medicine> _medicines = new JournalList<Medicine>();

        public MainForm()
        {
            InitializeComponent();
            _medicines.OnAdd += new EventHandler(JournalList<Medicine>.l_OnAdd);
            _medicines.OnDelete += new EventHandler(JournalList<Medicine>.l_OnDelete);
            _medicines.OnChange += new EventHandler(JournalList<Medicine>.l_OnChange);
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

        }
    }
}
