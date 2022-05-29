using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Medicine
    {
        public string Title { get; set; }

        public string Country { get; set; }

        public string ShelfLife { get; set; }

        public int MinimalAge { get; set; }

        public Medicine(string title,
            string country,
            string shelfLife,
            int minimalAge)
        {
            this.Title = title;

            this.ShelfLife = shelfLife;

            this.MinimalAge = minimalAge;

            this.Country = country;
        }

        public Medicine(string title, string country, string shelfLife) : this(title,
           country,
           shelfLife,
           8)
        {

        }

        public Medicine(string title, string country) : this(title,
            country,
            "2 года")
        {

        }

        public Medicine(string title) : this(title,
            "Беларусь")
        {

        }

        public Medicine() : this("Парацетамол")
        {

        }

        public override bool Equals(object obj)
        {
            if (obj is Medicine
                && obj != null)
            {
                Medicine tempComputer = (Medicine)obj;

                if (this.Title == tempComputer.Title
                    && this.ShelfLife == tempComputer.ShelfLife
                    && this.MinimalAge == tempComputer.MinimalAge
                    && this.Country == tempComputer.Country)
                {
                    return true;
                }
            }

            return false;
        }

        public virtual string Show()
        {
            return $"Название: {Title}\n" +
                $"Страна производства: {Country}\n" +
                $"Минимальный возраст для употребления: {MinimalAge} лет\n" +
                $"Срок годности: {ShelfLife}";
        }

        public override string ToString()
        {
            return $"{Title}, {Country}, {MinimalAge}, {ShelfLife}";
        }
    }
}
