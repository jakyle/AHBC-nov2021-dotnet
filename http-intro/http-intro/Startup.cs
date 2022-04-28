using http_intro.Services;
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

namespace http_intro
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


            // THis is how you pull out appsetttings.json and store it into a global object that you
            // will use throughout your application
            services.Configure<StarWarsClientConfig>(Configuration.GetSection("StarWarsClientConfig"));
            services.Configure<DBConfig>(Configuration.GetSection("ConnectionStrings"));

            // Configure will Get the Section you want out of your appsettings.Json, and BIND IT
            // ie. create an object for you of the type you provide in the Configure Method
            services.AddHttpClient<IStarWarsClient, StarWarsClient>(httpClient =>
            {
                // this is how you pull out a appsettings.json value that you will only use for 
                // setting up another service for your services collection. in other words, you DO NOT
                // need to use it as a global setting.
                var config = new StarWarsClientConfig();
                Configuration.GetSection("StarWarsClientConfig").Bind(config);
                httpClient.BaseAddress = new Uri(config.BaseUrl);
            });


            services.AddControllersWithViews();
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
