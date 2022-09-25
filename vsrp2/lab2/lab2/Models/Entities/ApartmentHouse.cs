namespace lab2.Models.Entities
{
    public class ApartmentHouse : ResidentialBuilding
    {
        public override string GetCreatedDateTime()
        {
            return _createdEntityDateTime.ToString("MM/dd/yyyy H:mm");
        }
    }
}
