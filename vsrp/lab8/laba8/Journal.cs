using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace laba8
{
    public class JournalList<T> : List<T>
    {
        public event EventHandler OnAdd;

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
            MessageBox.Show("Element added...");
            History.Add(e.)
        }
    }
}
