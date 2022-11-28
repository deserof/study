namespace lab8.Storage
{
    internal static class UserStorage
    {
        public static UserLoginResponseModel Current { get; set; } = new();

        public static List<Ointment> Ointments { get; set; } = new();

        public static List<Medicine> Medicines { get; set; } = new();

        public static List<Pills> Pills { get; set; } = new();
    }
}
