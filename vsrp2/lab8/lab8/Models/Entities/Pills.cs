﻿namespace laba8.Models.Entities
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

        public override string GetCreatedDateTime()
        {
            return _createdEntityDateTime.ToString("dddd, dd MMMM yyyy");
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
            return @$"Название: {Title}
Страна производства: {Country}
Минимальный возраст для применения: {MinimalAge} лет
Срок годности: {ShelfLife}
Количество: {Quantity} штук
Цвет: {Color}
Дата создания: {_createdEntityDateTime}";
        }

        public override string ToString()
        {
            return $"Таблетки| Название: {Title}, Срок годности: {ShelfLife}, Количество: {Quantity}";
        }
    }
}
