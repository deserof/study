// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pills.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Pills type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace laba8
{
    /// <summary>
    /// The pills.
    /// </summary>
    public class Pills : Medicine
    {
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pills"/> class.
        /// </summary>
        /// <param name="color">
        /// The color.
        /// </param>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        public Pills(string color,int quantity)
        {
            this.Quantity = quantity;

            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pills"/> class.
        /// </summary>
        /// <param name="color">
        /// The color.
        /// </param>
        public Pills(string color)
            : this(color, 20)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pills"/> class.
        /// </summary>
        public Pills()
            : this("Белый")
        {
        }

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool Equals(object obj)
        {
            var pills = obj as Pills;
            if (pills == null) return false;

            return this.Title == pills.Title
                   && this.ShelfLife == pills.ShelfLife
                   && this.MinimalAge == pills.MinimalAge
                   && this.Country == pills.Country
                   && this.Quantity == pills.Quantity
                   && this.Color == pills.Color;
        }

        /// <summary>
        /// The show.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
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
