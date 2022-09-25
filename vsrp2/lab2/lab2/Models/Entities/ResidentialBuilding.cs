using lab2.Models.Enums;
using static lab2.Extensions.EnumExtension;

namespace lab2.Models.Entities
{
    public class ResidentialBuilding
    {
        protected readonly DateTime _createdEntityDateTime = DateTime.Now;
        protected string _address = string.Empty;
        protected int? _entrances;
        protected int? _floors;
        protected ConstructionStatusType _constructionStatusType;

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

        public virtual string GetCreatedDateTime()
        {
            return _createdEntityDateTime.ToString("MM/dd/yyyy");
        }
    }
}
