using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ClerkTracker.Client.Mvc
{

    /// the entry point for a web application
    public class Startup
    {
        readonly string AllowSpecificOrigins = "_allowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        [EnableCors]
        public void ConfigureServices(IServiceCollection services)
        {
            System.Console.WriteLine("StartUp");

            services.AddCors(options =>
            {
                options.AddPolicy(name: AllowSpecificOrigins,
                              builder =>
                              {
                                  builder.WithOrigins("https://example1.com",
                                                      "https://example1.com"
                                                      );
                              });
            });
            
            //  c) foot
            services.AddControllersWithViews();


        }// /'ConfigureServices'

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
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
            
        }// /md 'Configure'

    }// /cla 'StartUp'
}// /ns 'ClerkTracker.Client.DailyPlan'
// [EoF]