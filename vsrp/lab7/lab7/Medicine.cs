﻿using System;

namespace lab7
{
    public class Medicine
    {
        private Country _country;

        public string Title { get; set; }

        public string ShelfLife { get; set; }

        public string Country
        {
            get => _country.ToString();

            set => _country = (Country)Enum.Parse(typeof(Country), value);
        }

        public int NumberOfTablets { get; set; }

        public Medicine(string title,
            string shelfLife,
            Country country,
            int numberOfTablets)
        {
            Title = title;
            ShelfLife = shelfLife;
            Country = country.ToString();
            NumberOfTablets = numberOfTablets;
        }

        public Medicine(
            string title,
            string shelfLife,
            Country country) : this(title, shelfLife, country,
           50)
        {
        }

        public Medicine(
            string title,
            string shelfLife)
            : this(title, shelfLife, lab7.Country.Belarus)
        {
        }

        public Medicine(string title)
            : this(title,
            "3 года")
        {
        }

        public Medicine()
            : this("Цитрамон")
        {
        }
    }
}
