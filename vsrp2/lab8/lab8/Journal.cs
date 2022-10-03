namespace laba8
{
    public class JournalList<T> : List<T>
    {
        public delegate void AddDelegate(T item);

        public event AddDelegate OnMyAdd;

        public event EventHandler OnAdd;

        public event EventHandler OnDelete;

        public event EventHandler OnChange;

        public new void Add(T item)
        {
            if (null != OnMyAdd)
            {
                OnMyAdd(item);
            }

            base.Add(item);
        }

        public List<string> History = new List<string>();
    }
}
