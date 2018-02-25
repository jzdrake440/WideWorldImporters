using DataTables.Models;
using DataTables.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTables.Extensions
{
    public static class Extensions
    {
        public static void AddPpeService(this IServiceCollection services, IPpeProfile profile)
        {
            services.AddTransient<IPpeService, PpeService>(s => profile.BuildService());
        }
    }
}
