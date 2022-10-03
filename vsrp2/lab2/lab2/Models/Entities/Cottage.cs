namespace lab2.Models.Entities
{
    public class Cottage : ResidentialBuilding
    {
        private int _windows;

        private int _rooms;

        private int _square;

        public int Windows { get { return _windows; } set { _windows = value; } }

        public int Rooms { get { return _rooms; } set { _rooms = value; } }

        public int Square { get { return _square; } set { _square = value; } }

        public override string GetCreatedDateTime()
        {
            return _createdEntityDateTime.ToString("dddd, dd MMMM yyyy");
        }

        public override string ToString()
        {
            return $"{nameof(_address)} {_address} - {nameof(_entrances)} {_entrances} - {nameof(_floors)} {_floors} - " +
                $"{nameof(ConstructionStatusType)} {ConstructionStatusType} - {nameof(Windows)} {Windows} - {nameof(Rooms)}{Rooms} - " +
                $"{nameof(GetCreatedDateTime)}{GetCreatedDateTime()}";
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Cottage)) return false;

            var res = obj as Cottage;

            return _square == res._square
                   && _windows == res._windows
                   && _rooms == res._rooms 
                   && base.Equals(obj);
        }
    }
}
