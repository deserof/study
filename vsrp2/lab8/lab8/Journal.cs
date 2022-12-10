namespace laba8
{
    public class JournalList<T> : List<T>
    {
        public delegate void CustomDelegate(T item);

        public event CustomDelegate OnMyAdd;

        public event EventHandler OnAdd;

        public event EventHandler OnDelete;

        public event CustomDelegate OnChange;

        public new void Add(T item)
        {
            if (null != OnMyAdd)
            {
                OnMyAdd(item);
            }

            base.Add(item);
        }

        public void Change(T item)
        {
            if (null != OnChange)
            {
                OnChange(item);
            }
        }
    }
}
