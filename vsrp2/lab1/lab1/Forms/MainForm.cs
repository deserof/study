using lab1.Models;
using lab1.Storage;

namespace lab1
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
            if (EntitiesStorage.ResidentialBuilding is not null)
            {
                var showDataForm = new ShowDataForm(EntitiesStorage.ResidentialBuilding);
                showDataForm.ShowDialog();
            }
            else
            {
                validLabel.Visible = true;
            }
        }
    }
}