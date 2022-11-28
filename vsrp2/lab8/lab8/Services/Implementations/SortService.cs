using lab8.Collections;
using lab8.Storage;
using laba8.Models.Entities;

namespace lab8.Services.Implementations
{
    internal class SortService
    {
        public static Medicine[] SortPillsByDate(CustomMedicineCollection collection)
        {
            List<Medicine> result = new List<Medicine>();

            foreach (var item in UserStorage.Medicines)
            {
                if (item is Pills)
                {
                    result.Add(item);
                }
            }

            var arrResult = result.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static Medicine[] SortOintmentsByDate(CustomMedicineCollection collection)
        {
            List<Medicine> result = new List<Medicine>();

            foreach (var item in UserStorage.Medicines)
            {
                if (item is Ointment)
                {
                    result.Add(item);
                }
            }

            var arrResult = result.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static Medicine[] SortAllByDate(CustomMedicineCollection collection)
        {
            var arrResult = UserStorage.Medicines.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static List<Medicine> SortAllByPrice()
        {
            var list = UserStorage.Medicines;

            list.Sort();

            return list;
        }

        public static List<Medicine> SortPillsByPrice()
        {
            List<Medicine> result = new List<Medicine>();

            foreach (var item in UserStorage.Medicines)
            {
                if (item is Pills)
                {
                    result.Add(item);
                }
            }

            result.Sort();

            return result;
        }

        public static List<Medicine> SortOintmentsByPrice()
        {
            List<Medicine> result = new List<Medicine>();

            foreach (var item in UserStorage.Medicines)
            {
                if (item is Ointment)
                {
                    result.Add(item);
                }
            }

            result.Sort();

            return result;
        }

        public static Medicine[] SortPillsByCreatedDate(PillsCollection collection)
        {
            List<Pills> result = new List<Pills>();

            foreach (var item in UserStorage.Medicines)
            {
                if (item is Pills)
                {
                    result.Add((Pills)item);
                }
            }

            var arrResult = result.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static Medicine[] SortOintmentsByTitle(OintmentCollection collection)
        {
            List<Ointment> result = new List<Ointment>();

            foreach (var item in UserStorage.Medicines)
            {
                if (item is Ointment)
                {
                    result.Add((Ointment)item);
                }
            }

            var arrResult = result.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }
    }
}
