using lab8.Forms;
using lab8.Services.Implementations;
using lab8.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

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

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AccountForm(serviceProvider));
        }
    }
}