using lab6.Di;
using lab6.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace lab6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildDi()
                .BuildServiceProvider();

            ITextService textService = serviceProvider.GetService<ITextService>();
            IHistoryService historyService = serviceProvider.GetService<IHistoryService>();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lab6(textService, historyService));
        }
    }
}
