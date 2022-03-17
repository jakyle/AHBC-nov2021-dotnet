using DI_Container_and_web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Container_and_web
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

            // Dependancy life cycle
            // singleton - This dependancy will EXIST during the ENTIRE life of the application, while the app is running, this SINGLE 
            // instance will exist in memory
            //
            // Scoped    - This dependancy will get created PER HTTP REQUEST, in other words, anytime you get a request in, this 
            // depedancy will be created and exist during the lifetime of that request/response
            //
            // Transient - for every class that depends on this dependancy, a NEW instance of this dependancy will be created
            // for EACH class that depends on it.
            //

            services.AddControllersWithViews();
            services.AddSingleton<ICalculator, Calculator>();
            services.AddTransient<NoGoodService>();
            // services..AddSomeShit
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
