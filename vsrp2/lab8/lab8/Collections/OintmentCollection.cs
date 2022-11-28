using laba8.Models.Entities;
using System.Collections;

namespace lab8.Collections
{
    internal class OintmentCollection : IEnumerable, IComparer<Ointment>
    {
        private readonly List<Ointment> _ointment;

        int position = -1;

        public object Current
        {
            get
            {
                if (position == -1 || position >= _ointment.Count)
                {
                    throw new ArgumentException();
                }

                return _ointment[position];
            }
        }

        public OintmentCollection(List<Ointment> computers)
        {
            _ointment = computers;
        }

        public int Compare(Ointment x, Ointment y)
        {
            return string.Compare(x.Title, y.Title);
        }

        public bool MoveNext()
        {
            if (position < _ointment.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => position = -1;

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _ointment.Count; i++)
            {
                yield return _ointment[i];
            }
        }
    }
}
