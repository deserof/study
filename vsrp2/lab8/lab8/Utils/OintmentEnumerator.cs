namespace lab8.Utils
{
    public class MedicineEnumerator : IEnumerator
    {
        private int position = -1;

        private readonly CustomMedicineCollection customMedicineCollection;

        public MedicineEnumerator(CustomMedicineCollection customMedicineCollection)
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

                while (!customMedicineCollection[position].IsSold && position < customMedicineCollection.Length - 1)
                {
                    position++;
                }

                return true;
            }

            return false;
        }
        public void Reset() => position = -1;
    }
}
