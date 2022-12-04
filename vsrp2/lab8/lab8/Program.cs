using lab8.Models.Entities;

namespace lab8
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var container = new ServiceCollection();

            container.AddSingleton<IHttpService, HttpService>();
            container.AddSingleton<IReaderService, ReaderService>();
            container.AddSingleton<IWriterService, WriterService>();

            var serviceProvider = container.BuildServiceProvider();

            //GenerateData();
            //var wr = serviceProvider.GetRequiredService<IWriterService>();
            //wr.Write(Storage.Medicines, "..\\..\\..\\Products.json");

            var reader = serviceProvider.GetRequiredService<IReaderService>();
            var readedMeds = reader.Read<List<Medicine>>("..\\..\\..\\Products.json");
            Storage.Medicines.AddRange(readedMeds);

            ApplicationConfiguration.Initialize();
            Application.Run(new AccountForm(serviceProvider));
        }

        private static void GenerateData()
        {
            var country = new[] { "Беларусь", "Россия", "Китай", "Германия" };
            var minAgeType = new[] { 8, 14, 18 };
            var shelfLife = new[] { "1 месяц", "3 месяца", "6 месяцев", "1 год", "3 года"};

            var pillsTitle = new[] { "Антиоксикапс", "Омепразол", "Мегасеф", "Биоблис" };
            var pillsColor = new[] { "желтый", "синий", "белый", "черный", "фиолетовый"};

            var ointmentTitle = new[] { "Бепантен", "Кловейт", "Аргезин" };
            var ointmentType = new[] { "Гидрофильная", "Гидрофобная", "Дифильная" };

            var pillsFaker = new Faker<Pills>()
                .RuleFor(x => x.Price, c => c.Random.Number(5, 100))
                .RuleFor(x => x.Title, c => c.PickRandom(pillsTitle))
                .RuleFor(x => x.MinimalAge, c => c.PickRandom(minAgeType))
                .RuleFor(x => x.Country, c => c.PickRandom(country))
                .RuleFor(x => x.ShelfLife, c => c.PickRandom(shelfLife))
                .RuleFor(x => x.Color, c => c.PickRandom(pillsColor))
                .RuleFor(x => x.Quantity, c => c.Random.Number(10, 100));

            var ointmentFaker = new Faker<Ointment>()
                .RuleFor(x => x.Price, c => c.Random.Number(5, 100))
                .RuleFor(x => x.Title, c => c.PickRandom(ointmentTitle))
                .RuleFor(x => x.MinimalAge, c => c.PickRandom(minAgeType))
                .RuleFor(x => x.Country, c => c.PickRandom(country))
                .RuleFor(x => x.OitmentType, c => c.PickRandom(ointmentType))
                .RuleFor(x => x.Volume, c => c.Random.Number(50, 200))
                .RuleFor(x => x.ShelfLife, c => c.PickRandom(shelfLife));

            var pills = pillsFaker.Generate(30);
            var ointment = ointmentFaker.Generate(30);

            Storage.Pills.AddRange(pills);

            Storage.Ointments.AddRange(ointment);

            Storage.Medicines.AddRange(pills);
            Storage.Medicines.AddRange(ointment);
        }
    }
}