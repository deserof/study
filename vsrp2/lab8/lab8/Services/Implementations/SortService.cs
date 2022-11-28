namespace lab8.Services.Implementations
{
    internal class SortService
    {
        public static Medicine[] SortPillsByDate(CustomMedicineCollection collection)
        {
            var result = new List<Medicine>();

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
            var result = new List<Medicine>();

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
            var result = new List<Medicine>();

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
            var result = new List<Medicine>();

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
            var result = new List<Pills>();

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
            var result = new List<Ointment>();

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
