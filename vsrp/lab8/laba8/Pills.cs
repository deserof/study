using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Pills : Medicine
    {
        public int Quantity { get; set; }

        public string Color { get; set; }

        public Pills(string color,int quantity)
            : base()
        {
            this.Quantity = quantity;

            this.Color = color;
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
            if (obj is Pills
                && obj != null)
            {
                Pills pills = (Pills)obj;

                if (this.Title == pills.Title
                    && this.ShelfLife == pills.ShelfLife
                    && this.MinimalAge == pills.MinimalAge
                    && this.Country == pills.Country
                    && this.Quantity == pills.Quantity
                    && this.Color == pills.Color)
                {
                    return true;
                }
            }

            return false;
        }

        public override string Show() => $"Название: {Title}\n" +
          $"Страна производства: {Country}\n" +
          $"Минимальный возраст для применения: {MinimalAge} лет\n" +
          $"Срок годности: {ShelfLife}\n" +
          $"Количество: {Quantity} штук\n" +
          $"Цвет: {Color}";

        public override string ToString() => string.Format($"Таблетки| Название: {Title}" +
            $" Срок годности: {ShelfLife}" +
            $" Количество: {Quantity}");
    }
}
