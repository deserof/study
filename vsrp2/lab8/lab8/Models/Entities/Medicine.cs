using lab8.Models.Enums;
using static lab8.Extensions.EnumExtension;

namespace laba8.Models.Entities
{
    public class Medicine
    {
        protected DateTime _createdEntityDateTime = DateTime.Now;

        public string Title { get; set; }

        public string Country { get; set; }

        public string ShelfLife { get; set; }

        private decimal _price;

        private static double nds = 20;

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

        public DateTime ShowEntityDateTime
        {
            get
            {
                return _createdEntityDateTime;
            }
        }

        public int ChangeEntityDateTime
        {
            set
            {
                _createdEntityDateTime = _createdEntityDateTime.AddYears(Math.Abs(_createdEntityDateTime.Year - value));
            }
            get
            {
                return _createdEntityDateTime.Year;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public decimal PriceWithNds
        {
            get
            {
                return _price + _price * (decimal)(nds / 100);
            }
        }

        public bool this[decimal price]
        {
            get
            {
                if (price > _price)
                {
                    return true;
                }

                return false;
            }
        }

        public Medicine(Medicine medicine)
        {
            Title = medicine.Title;
            Country = medicine.Country;
            ShelfLife = medicine.ShelfLife;
            MinimalAge = medicine.MinimalAge;
            ChangeEntityDateTime = medicine.ChangeEntityDateTime;
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
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Medicine medicine)) return false;

            return Title == medicine.Title
                   && ShelfLife == medicine.ShelfLife
                   && MinimalAge == medicine.MinimalAge
                   && Country == medicine.Country
                   && ShowEntityDateTime == medicine.ShowEntityDateTime;
        }

        public virtual string Show()
        {
            return @$"Название: {Title}
Страна производства: {Country}
Минимальный возраст для употребления: {MinimalAge} лет
Срок годности: {ShelfLife}
Цена: {PriceWithNds}";
        }

        public override string ToString()
        {
            return $"{Title}, {Country}, {MinimalAge}, {ShelfLife}";
        }

        public static bool operator ==(Medicine med1, Medicine med2)
        {
            return med1.Equals(med2);
        }

        public static bool operator !=(Medicine med1, Medicine med2)
        {
            return !med1.Equals(med2);
        }
    }
}
