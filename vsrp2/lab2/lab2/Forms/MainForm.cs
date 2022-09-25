using lab2.Storage;

namespace lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            validLabel.Visible = false;
        }

        private void enterData_Click(object sender, EventArgs e)
        {
            var enterDataForm = new EnterDataForm();
            enterDataForm.ShowDialog();
        }

        private void showData_Click(object sender, EventArgs e)
        {
            if (EntitiesStorage.ResidentialBuildings is not null)
            {
                var showDataForm = new ShowDataForm(EntitiesStorage.ResidentialBuildings);
                showDataForm.ShowDialog();
            }
            else
            {
                validLabel.Visible = true;
            }
        }
    }
}