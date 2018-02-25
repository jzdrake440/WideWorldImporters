using DataTables.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DataTables.Services
{
    public static class PpeServiceConfig
    {
        public static void AddPpeService(this IServiceCollection services, IPpeProfile profile)
        {
            services.AddTransient<IPpeService, PpeService>(p => profile.BuildService()); //TODO make less singleton; maybe use a similar method as AutoMapper?
        }
    }
}
