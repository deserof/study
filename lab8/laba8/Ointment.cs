using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Ointment : Medicine
    {
        public int Volume { get; set; }

        public string Type { get; set; }

        public Ointment(int volume,
            string type)
            : base()
        {
            this.Volume = volume;

            this.Type = type;
        }

        public Ointment(int volume)
            : this(volume, "Гидрофильная")
        {
        }

        public Ointment()
            : this(20)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj is Pills
                && obj != null)
            {
                Ointment ointment = (Ointment)obj;

                if (this.Title == ointment.Title
                    && this.ShelfLife == ointment.ShelfLife
                    && this.MinimalAge == ointment.MinimalAge
                    && this.Country == ointment.Country
                    && this.Volume == ointment.Volume
                    && this.Type == ointment.Type)
                {
                    return true;
                }
            }

            return false;
        }

        public override string Show() => $"Название: {Title}\n" +
          $"Страна производства: {Country}\n" +
          $"Минимальный возраст для употребления: {MinimalAge} лет\n" +
          $"Срок годности: {ShelfLife}\n" +
          $"Объем: {Volume} мл\n" +
          $"Тип: {Type}";

        public override string ToString() => string.Format($"Мазь| Название: {Title} " +
            $"Срок годности: {ShelfLife}");
    }
}
