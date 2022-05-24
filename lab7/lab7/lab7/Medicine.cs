using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Medicine
    {
        private Country country; 

        public string Title { get; set; }

        public string ShelfLife { get; set; }

        public string Country
        {
            get => country.ToString();

            set => country = (Country)Enum.Parse(typeof(Country), value);
        }

        public int NumberOfTablets { get; set; }

        public Medicine(string title,
            string shelfLife,
            Country country,
            int numberOfTablets)
        {
            this.Title = title;

            this.ShelfLife = shelfLife;

            this.Country = country.ToString();

            this.NumberOfTablets = numberOfTablets;
        }

        public Medicine(string title, string shelfLife, Country country) : this(title,
           shelfLife,
           country,
           50)
        {

        }

        public Medicine(string title, string shelfLife) : this(title,
            shelfLife,
            lab7.Country.Belarus)
        {
            
        }

        public Medicine(string title) : this(title,
            "3 года")
        {

        }

        public Medicine() : this("Цитрамон")
        {

        }
    }
}
