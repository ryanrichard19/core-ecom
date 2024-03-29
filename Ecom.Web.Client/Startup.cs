using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.BLL.Factories;
using Ecom.BLL.Handlers;
using Ecom.BLL.Managers;
using Ecom.BLL.Validators;
using Ecom.Data.Contexts;
using Ecom.Domain.Contacts.Factories;
using Ecom.Domain.Contacts.Handlers;
using Ecom.Domain.Contacts.Repositories;
using Ecom.Domain.Contacts.Validators;
using Ecom.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Ecom.Web.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<EcomDbContext>();
            services.AddTransient<ILogger, Logger>();
            services.AddTransient<IValidator<Product>, ProductValidator>();
            services.AddTransient<IExceptionHandler, ExceptionHandler>();
            services.AddTransient<IEntityFactory<Product>, ProductFactory>();
            services.AddTransient<IProductRepository, ProductManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
