namespace lab8.Data
{
    internal static class Storage
    {
        public static UserModel CurrentUser { get; set; } = new();

        public static List<Ointment> Ointments { get; set; } = new();

        public static List<Medicine> Medicines { get; set; } = new();

        public static List<Pills> Pills { get; set; } = new();

        public static List<Medicine> History { get; set; }
    }
}
