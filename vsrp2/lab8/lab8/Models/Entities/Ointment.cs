using lab8.Models.Enums;
using static lab8.Extensions.EnumExtension;

namespace laba8.Models.Entities
{
    public class Ointment : Medicine
    {
        public int Volume { get; set; }

        private OitmentType _type;

        public string OitmentType
        {
            get
            {
                return _type.GetDescription();
            }
            set
            {
                _type = GetEnumFromDescription<OitmentType>(value);
            }
        }

        public Ointment(
            int volume,
            string type)
        {
            Volume = volume;
            OitmentType = type;
        }

        public Ointment(int volume)
            : this(volume, "Гидрофильная")
        {
        }

        public Ointment()
            : this(20)
        {
        }

        public override string GetCreatedDateTime()
        {
            return _createdEntityDateTime.ToString("MM/dd/yyyy H:mm");
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Pills)) return false;

            var ointment = obj as Ointment;

            return Title == ointment.Title
                   && ShelfLife == ointment.ShelfLife
                   && MinimalAge == ointment.MinimalAge
                   && Country == ointment.Country
                   && Volume == ointment.Volume
                   && OitmentType == ointment.OitmentType;
        }

        public override string Show()
        {
            return @$"Название: {Title}
Страна производства: {Country}
Минимальный возраст для употребления: {MinimalAge} лет
Срок годности: {ShelfLife}
Объем: {Volume} мл
Тип: {OitmentType}
"Дата создания: {_createdEntityDateTime}";
        }

        public override string ToString()
        {
            return $"Мазь| Название: {Title}, Срок годности: {ShelfLife}";
        }
    }
}
