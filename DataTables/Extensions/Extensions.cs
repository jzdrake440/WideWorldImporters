using DataTables.Models;
using DataTables.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace DataTables.Extensions
{
    public static class Extensions
    {
        public static void AddPpeService(this IServiceCollection services, IPpeProfile profile)
        {
            services.AddTransient<IPpeService, PpeService>(s => profile.BuildService());
        }

        public static string GetDisplayName(this PropertyInfo pi)
        {
            var attr = pi.GetCustomAttribute<DisplayAttribute>();
            return attr?.Name ?? pi.Name;
        }

        public static string GetNameCamelCase(this PropertyInfo pi)
        {
            return pi.Name.Substring(0,1).ToLower() +
                   pi.Name.Substring(1);
        }
    }
}
