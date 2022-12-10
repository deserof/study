namespace lab8.Utils
{
    public class OintmentEnumerator : IEnumerator
    {
        private int position = -1;

        private readonly CustomMedicineCollection customMedicineCollection;

        public OintmentEnumerator(CustomMedicineCollection customMedicineCollection)
        {
            this.customMedicineCollection = customMedicineCollection;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= customMedicineCollection.Length)
                {
                    throw new ArgumentException(nameof(position));
                }

                return customMedicineCollection[position];
            }
        }
        public bool MoveNext()
        {
            if (position < customMedicineCollection.Length - 1)
            {
                position++;

                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset() => position = -1;
    }
}
