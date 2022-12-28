namespace laba8
{
    public class Journal<T>
    {
        public delegate void Handler(T item);

        public event Handler OnAdd;

        public event Handler OnSell;

        public event Handler OnDelete;

        public event Handler OnChange;

        public void Add(T item)
        {
            if (null != OnAdd)
            {
                OnAdd(item);
            }
        }

        public void Change(T item)
        {
            if (null != OnChange)
            {
                OnChange(item);
            }
        }

        public void Sell(T item)
        {
            if (null != OnSell)
            {
                OnSell(item);
            }
        }

        public void Delete(T item)
        {
            if (null != OnDelete)
            {
                OnDelete(item);
            }
        }
    }
}
