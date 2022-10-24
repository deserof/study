namespace lab8.Interfaces
{
    public interface ISell
    {
        DateTime SaleDate { get; set; }

        bool IsSold { get; set; }

        string Customer { get; set; }

        void Sell();
    }
}
