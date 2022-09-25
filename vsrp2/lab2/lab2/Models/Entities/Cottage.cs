namespace lab2.Models.Entities
{
    public class Cottage : ResidentialBuilding
    {
        private int _windows;

        public override string GetCreatedDateTime()
        {
            return _createdEntityDateTime.ToString("dddd, dd MMMM yyyy");
        }
    }
}
