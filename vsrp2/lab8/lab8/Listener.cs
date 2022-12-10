using lab8.Models.Entities;

namespace lab8
{
    public class Listener
    {
        public static void l_OnMyAddMedicine(Medicine medicine)
        {
            var hist = $"{DateTime.Now} Element has been added :{medicine}";

            Storage.History.Add(hist);
        }

        public static void l_OnAdd(object sender, EventArgs e)
        {
            MessageBox.Show($"Element has been added {sender}");
        }

        public static void l_OnDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Element has been deleted...");
        }

        public static void l_OnChange(Medicine medicine)
        {
            var hist = $"{DateTime.Now} Element has been changed :{medicine}";

            Storage.History.Add(hist);
        }
    }
}
