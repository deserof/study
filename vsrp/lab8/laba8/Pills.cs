namespace laba8
{
    public class Pills : Medicine
    {
        public int Quantity { get; set; }

        public string Color { get; set; }

        public Pills(string color, int quantity)
        {
            Quantity = quantity;
            Color = color;
        }

        public Pills(string color)
            : this(color, 20)
        {
        }

        public Pills()
            : this("Белый")
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Pills pills)) return false;

            return Title == pills.Title
                   && ShelfLife == pills.ShelfLife
                   && MinimalAge == pills.MinimalAge
                   && Country == pills.Country
                   && Quantity == pills.Quantity
                   && Color == pills.Color;
        }

        public override string Show()
        {
            return $"Название: {Title}\n" +
                 $"Страна производства: {Country}\n" +
                 $"Минимальный возраст для применения: {MinimalAge} лет\n" +
                 $"Срок годности: {ShelfLife}\n" +
                 $"Количество: {Quantity} штук\n" +
                 $"Цвет: {Color}";
        }

        public override string ToString()
        {
            return $"Таблетки| Название: {Title}, Срок годности: {ShelfLife}, Количество: {Quantity}";
        }
    }
}
