namespace laba8
{
    public class Ointment : Medicine
    {
        public int Volume { get; set; }

        public string Type { get; set; }

        public Ointment(int volume,
            string type)
        {
            Volume = volume;
            Type = type;
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
            if (!(obj is Pills)) return false;

            var ointment = obj as Ointment;

            return Title == ointment.Title
                   && ShelfLife == ointment.ShelfLife
                   && MinimalAge == ointment.MinimalAge
                   && Country == ointment.Country
                   && Volume == ointment.Volume
                   && Type == ointment.Type;
        }

        public override string Show()
        {
            return $"Название: {Title}\n" +
                 $"Страна производства: {Country}\n" +
                 $"Минимальный возраст для употребления: {MinimalAge} лет\n" +
                 $"Срок годности: {ShelfLife}\n" +
                 $"Объем: {Volume} мл\n" +
                 $"Тип: {Type}";
        }

        public override string ToString()
        {
            return $"Мазь| Название: {Title}, Срок годности: {ShelfLife}";
        }
    }
}
