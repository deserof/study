namespace laba8
{
    public class Medicine
    {
        public string Title { get; set; }

        public string Country { get; set; }

        public string ShelfLife { get; set; }

        public int MinimalAge { get; set; }

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
