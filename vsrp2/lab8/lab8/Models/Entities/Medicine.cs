using lab8.Models.Enums;
using static lab8.Extensions.EnumExtension;

namespace laba8.Models.Entities
{
    public class Medicine
    {
        protected readonly DateTime _createdEntityDateTime = DateTime.Now;

        public string Title { get; set; }

        public string Country { get; set; }

        public string ShelfLife { get; set; }

        private MinimalAgeType _minimalAgeType;

        public int MinimalAge
        {
            get
            {
                return Convert.ToUInt16(_minimalAgeType.GetDescription());
            }
            set
            {
                _minimalAgeType = GetEnumFromDescription<MinimalAgeType>(value.ToString());
            }
        }

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

        public Medicine(
            string title,
            string country,
            string shelfLife,
            int minimalAge)
        {
            Title = title;
            ShelfLife = shelfLife;
            MinimalAge = minimalAge;
            Country = country;
        }

        public Medicine(
            string title,
            string country,
            string shelfLife)
            : this(title, country, shelfLife, 8)
        {
        }

        public Medicine(
            string title,
            string country)
            : this(title, country, "2 года")
        {
        }

        public Medicine(string title)
            : this(title,
            "Беларусь")
        {
        }

        public Medicine()
            : this("Парацетамол")
        {
        }

        public virtual string GetCreatedDateTime()
        {
            return _createdEntityDateTime.ToString("MM/dd/yyyy");
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Medicine tempComputer)) return false;

            return Title == tempComputer.Title
                   && ShelfLife == tempComputer.ShelfLife
                   && MinimalAge == tempComputer.MinimalAge
                   && Country == tempComputer.Country;
        }

        public virtual string Show()
        {
            return @$"Название: {Title}
Страна производства: {Country}
Минимальный возраст для употребления: {MinimalAge} лет
Срок годности: {ShelfLife}";
        }

        public override string ToString()
        {
            return $"{Title}, {Country}, {MinimalAge}, {ShelfLife}";
        }
    }
}
