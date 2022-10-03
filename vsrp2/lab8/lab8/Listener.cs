using laba8.Models.Entities;

namespace lab8
{
    public class Listener
    {
        public static void l_OnMyAddMedicine(Medicine sender)
        {
            if (sender is Pills pills)
            {
                MessageBox.Show($"boba {pills}");
            }

            if (sender is Ointment ointment)
            {
                MessageBox.Show(ointment.ToString());
            }

            //MessageBox.Show($"boba {sender}");
            //History.Add(e.)
        }

        public static void l_OnAdd(object sender, EventArgs e)
        {
            MessageBox.Show($"Element has been added {sender}");
        }

        public static void l_OnDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Element has been deleted...");
        }

        public static void l_OnChange(object sender, EventArgs e)
        {
            MessageBox.Show("Element has been changed...");
        }
    }
}
