using lab8.Forms;
using lab8.Services.Implementations;
using lab8.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Bogus;
using laba8.Models.Entities;
using lab8.Storage;
using lab8.Models.Enums;

namespace lab8
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new ServiceCollection();

            container.AddSingleton<IHttpService, HttpService>();

            var serviceProvider = container.BuildServiceProvider();

            GenerateData();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AccountForm(serviceProvider));
        }

        private static void GenerateData()
        {
            var country = new string[] { "Беларусь", "Россия", "Китай", "Германия" };
            var minAgeType = new int[] { 8, 14, 18 };
            var shelfLife = new string[] { "1 месяц", "3 месяца", "6 месяцев", "1 год", "3 года"};

            var pillsTitle = new string[] { "Антиоксикапс", "Омепразол", "Мегасеф", "Биоблис" };
            var pillsColor = new string[] { "желтый", "синий", "белый", "черный", "фиолетовый"};

            var ointmentTitle = new string[] { "Бепантен", "Кловейт", "Аргезин" };
            var ointmentType = new string[] { "Гидрофильная", "Гидрофобная", "Дифильная" };

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
                .RuleFor(x => x.Title, c => c.PickRandom(pillsTitle))
                .RuleFor(x => x.MinimalAge, c => c.PickRandom(minAgeType))
                .RuleFor(x => x.Country, c => c.PickRandom(country))
                .RuleFor(x => x.OitmentType, c => c.PickRandom(ointmentType))
                .RuleFor(x => x.Volume, c => c.Random.Number(50, 200))
                .RuleFor(x => x.ShelfLife, c => c.PickRandom(shelfLife));

            List<Pills> pills = pillsFaker.Generate(30);
            List<Ointment> ointment = ointmentFaker.Generate(30);

            UserStorage.Pills.AddRange(pills);

            UserStorage.Ointments.AddRange(ointment);

            UserStorage.Medicines.AddRange(pills);
            UserStorage.Medicines.AddRange(ointment);
        }
    }
}