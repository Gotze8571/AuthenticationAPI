using Generic.Domain.Configuration;
using Generic.Domain.Repositories.Concrete;
using Generic.Domain.Repositories.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAPI
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
            services.AddControllers();

            // Add functionality to inject IOptions<T>
            services.AddOptions();

            // Add our Config object so it can be injected
            services.Configure<AuthConfig>(Configuration.GetSection("Authentication"));

            // Add service health check
            services.AddHealthChecks();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AuthenticationAPI", Version = "v1" });
            });
            // Register Code First Migrations Dependencies
            // services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(
            //Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("SAP_BusinessLogic")));

            // Register Dapper Dependencies
            services.Configure<AuthConfig>(Configuration.GetSection("AppSettings"));
           // services.AddTransient<IDbConnection>(prov => new SqlConnection(prov.GetService<IConfiguration>().GetConnectionString("DefaultConnection")));

            // Register Repositories
            services.AddScoped<IAuthRepository, AuthRepository>();
            //services.AddScoped<IGenericRepository, GenericRepository>();

            // Register Services
            //services.AddTransient<IAccountSetupService, AccountSetupService>();
            


            // Register Helpers
            //services.AddScoped<IUtil, Util>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseHttpsRedirection();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "AuthenticationAPI v1"));
            }



            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/health");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
