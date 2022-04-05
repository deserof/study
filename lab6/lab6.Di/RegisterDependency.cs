using lab6.Repositories.Implementations;
using lab6.Repositories.Interfaces;
using lab6.Services.Implementations;
using lab6.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace lab6.Di
{
    public static class RegisterDependency
    {
        public static IServiceCollection BuildDi(this IServiceCollection services)
        {
            services.AddSingleton<IHistoryService, HistoryService>();
            services.AddSingleton<ITextService, TextService>();
            services.AddSingleton<ITextRepository, TextRepository>();
            return services;
        }
    }
}
