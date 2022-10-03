namespace laba8
{
    public class JournalList<T> : List<T>
    {
        public event EventHandler OnAdd;

        public event EventHandler OnDelete;

        public event EventHandler OnChange;

        public new void Add(T item)
        {
            if (null != OnAdd)
            {
                OnAdd(this, null);
            }

            base.Add(item);
        }

        public List<string> History = new List<string>();

        public static void l_OnAdd(object sender, EventArgs e)
        {
            MessageBox.Show($"Element has been added {sender}");
            //History.Add(e.)
        }

        public static void l_OnDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Element has been deleted...");
        }

        public static void l_OnChange(object sender, EventArgs e)
        {
            MessageBox.Show("Element has been changed...");
        }
    }
}
