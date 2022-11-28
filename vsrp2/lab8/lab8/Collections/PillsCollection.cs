using laba8.Models.Entities;
using System.Collections;

namespace lab8.Collections
{
    internal class PillsCollection : IEnumerable, IComparer<Pills>
    {
        private IEnumerable<Pills> _pills;

        public PillsCollection(IEnumerable<Pills> pills)
        {
            _pills = pills;
        }

        public int Compare(Pills x, Pills y)
        {
            int result = 0;

            if (x._createdEntityDateTime < y._createdEntityDateTime)
            {
                result = 1;
            }
            else if (x._createdEntityDateTime > y._createdEntityDateTime)
            {
                result = -1;
            }

            return result;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in _pills)
            {
                yield return item.Country;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
