using lab2.Models.Entities;
using lab2.Storage;

namespace lab2
{
    public partial class ShowDataForm : Form
    {
        public ShowDataForm()
        {
            InitializeComponent();

            buildingsListBox.Items.Clear();

            foreach (var building in EntitiesStorage.ResidentialBuildings)
            {
                buildingsListBox.Items.Add(building);
            }
        }
    }
}
