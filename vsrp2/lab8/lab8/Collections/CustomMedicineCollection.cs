using lab8.Models.Entities;

namespace lab8.Collections
{
    public class CustomMedicineCollection : IEnumerable, IComparer<Medicine>
    {
        private readonly List<Medicine> medicines;
        private readonly MedicineEnumerator medEnumaretor;

        public CustomMedicineCollection(List<Medicine> medicines)
        {
            this.medicines = medicines;
            medEnumaretor = new MedicineEnumerator(this);
        }

        public int Length => this.medicines.Count;
        public IEnumerator GetEnumerator()
        {
            return medEnumaretor;
        }

        public Medicine this[int index]
        {
            get 
            {
                if (index >= 0 && index < medicines.Count)
                    return this.medicines[index];

                return null;
            }

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

        //public IEnumerator GetEnumerator()
        //{
        //    foreach (var medicine in this.medicines)
        //    {
        //        yield return medicine.ToString();
        //    }
        //}
    }
}
