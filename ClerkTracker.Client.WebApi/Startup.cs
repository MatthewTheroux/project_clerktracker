// [!]. ABOUT
/// <title> ClerkTracker </title>
/// <authors>
///     <author> Jason Wong </author>
///     <author> Matthew T. Theroux </author>
/// </authors>

// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.OpenApi.Models;

/// 
namespace ClerkTracker.Client.WebApi
{
    /// the web entry point
    public class Startup
    {
        //  C]
        /// Load the configuration upon creation.
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //  B] Properties
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /// 
            services.AddControllers();
            
            ///
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ClerkTracker.Client.WebApi", Version = "v1" });
            });

            ///
            services.AddCors(options =>
            {
                options.AddPolicy("public", config =>
                {
                    // <...> todo: Secure.
                    config.AllowAnyOrigin();
                    config.AllowAnyMethod();
                    config.AllowAnyHeader();
                });
            });// /Cors

        }// /md 'ConfigureS3ervices'

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ClerkTracker.Client.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
