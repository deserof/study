using lab2.Models.Entities;
using lab2.Storage;

namespace lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            validLabel.Visible = false;
            appartmentHouseRadioButton.Checked = true;
        }

        private void enterData_Click(object sender, EventArgs e)
        {
            EnterDataForm enterDataForm;

            if (appartmentHouseRadioButton.Checked)
            {
                enterDataForm = new(new ApartmentHouse()); 
            }
            else
            {
                enterDataForm = new(new Cottage());
            }

            enterDataForm.ShowDialog();
        }

        private void showData_Click(object sender, EventArgs e)
        {
            if (EntitiesStorage.ResidentialBuildings is not null)
            {
                var showDataForm = new ShowDataForm();
                showDataForm.ShowDialog();
            }
            else
            {
                validLabel.Visible = true;
            }
        }
    }
}