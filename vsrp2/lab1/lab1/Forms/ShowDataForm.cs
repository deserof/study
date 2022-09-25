using lab1.Models;

namespace lab1
{
    public partial class ShowDataForm : Form
    {
        public ShowDataForm()
        {
            InitializeComponent();
        }

        public ShowDataForm(ResidentialBuilding residentialBuilding)
            : this()
        {
            addressViewlabel.Text = residentialBuilding.Address;
            entrancesViewlabel.Text = residentialBuilding.Entrances.ToString();
            floorsViewlabel.Text = residentialBuilding.Floors.ToString();
            constrStatusViewlabel.Text = residentialBuilding.ConstructionStatusType;
            createdTimeViewlabel.Text = residentialBuilding.CreatedEntityYear.ToString();
        }
    }
}
