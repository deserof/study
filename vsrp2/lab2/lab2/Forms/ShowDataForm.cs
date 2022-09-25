using lab2.Models.Entities;

namespace lab2
{
    public partial class ShowDataForm : Form
    {
        public ShowDataForm()
        {
            InitializeComponent();
        }

        public ShowDataForm(List<ResidentialBuilding> residentialBuildings)
            : this()
        {
            //addressViewlabel.Text = residentialBuilding.Address;
            //entrancesViewlabel.Text = residentialBuilding.Entrances.ToString();
            //floorsViewlabel.Text = residentialBuilding.Floors.ToString();
            //constrStatusViewlabel.Text = residentialBuilding.ConstructionStatusType;
            //createdTimeViewlabel.Text = residentialBuilding.CreatedEntityYear.ToString();
        }
    }
}
