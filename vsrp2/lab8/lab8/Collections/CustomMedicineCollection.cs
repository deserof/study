namespace lab8.Collections
{
    public class CustomMedicineCollection : IEnumerable, IComparer<Medicine>
    {
        private readonly List<Medicine> medicines;
        private readonly OintmentEnumerator ointmentEnumerator;

        public CustomMedicineCollection(List<Medicine> medicines)
        {
            this.medicines = medicines;
            ointmentEnumerator = new OintmentEnumerator(this);
        }

        public int Length => this.medicines.Count;

        public IEnumerator GetEnumerator()
        {
            foreach (var medicine in this.medicines)
            {
                yield return medicine.Title;
            }
        }

        //public IEnumerator GetEnumerator()
        //{
        //    return ointmentEnumerator;
        //}

        public Medicine this[int index]
        {
            get => this.medicines[index];
            set => this.medicines[index] = value;
        }

        public int Compare(Medicine x, Medicine y)
        {
            var result = 0;

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
    }
}
