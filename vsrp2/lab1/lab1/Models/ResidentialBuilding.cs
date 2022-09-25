using static lab1.Extensions.EnumExtension;

namespace lab1.Models
{
    public class ResidentialBuilding
    {
        private readonly DateTime _createdEntityDateTime = DateTime.Now;
        private string _address = string.Empty;
        private int? _entrances;
        private int? _floors;
        private ConstructionStatusType _constructionStatusType;

        public int CreatedEntityYear
        {
            get
            {
                return _createdEntityDateTime.Year;
            }
            set
            {
                _createdEntityDateTime.AddYears(value);
            } 
        }

        public string Address { get { return _address; } set { _address = value; } }

        public int? Entrances { get { return _entrances; } set { _entrances = value; } }

        public int? Floors { get { return _floors; } set { _floors = value; } }

        public string ConstructionStatusType 
        { 
            get 
            {
                return _constructionStatusType.GetDescription();
            } 
            set 
            {
                _constructionStatusType = GetEnumFromDescription<ConstructionStatusType>(value);
            } 
        }

        public ResidentialBuilding()
        {
        }

        public ResidentialBuilding(string address, int entrances, int floors)
        {
            _address = address;
            _entrances = entrances;
            _floors = floors;
        }

        public ResidentialBuilding(string address, int entrances, int floors, ConstructionStatusType constructionStatusType)
            : this(address, entrances, floors)
        {
            _constructionStatusType = constructionStatusType;
        }
    }
}
