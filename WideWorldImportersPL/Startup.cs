using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using WideWorldImporters.DAL;
using Microsoft.Extensions.Configuration;
using WideWorldImporters.BLL.Services;
using DataTables.Extensions;
using WideWorldImporters.DataTables;
using AutoMapper;
using DataTables.Services;

namespace WideWorldImporters
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services.AddDbContext<WideWorldImportersContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("WideWorldImporters")));


            services.AddAutoMapper();
            services.AddPpeService(new WwiBllPpeProfile());

            services.AddTransient<IPeopleService, PeopleService>();
            services.AddTransient<IDataTableService, DataTableService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
