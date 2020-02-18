using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Facturacion.API.Controllers;
using Facturacion.API.Infrastructure.AutoFac;
using Facturacion.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Facturacion.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public virtual IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddCustomDbContext(Configuration);
            
            //Agregado
            services.AddMediatR(typeof(Startup));

            var container = new ContainerBuilder();
            container.Populate(services);

            //container.RegisterModule(new MediatorModule());
            container.RegisterModule(new ApplicationModule(Configuration["ConnectionString"]));

            return new AutofacServiceProvider(container.Build());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {

            //var pathBase = Configuration["PATH_BASE"];
            //if (!string.IsNullOrEmpty(pathBase))
            //{
            //    loggerFactory.CreateLogger<Startup>().LogDebug("Using PATH BASE '{pathBase}'", pathBase);
            //    app.UsePathBase(pathBase);
            //}

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseCors("CorsPolicy");

            //app.UseSwagger()
            //   .UseSwaggerUI(c =>
            //   {
            //       c.SwaggerEndpoint($"{ (!string.IsNullOrEmpty(pathBase) ? pathBase : string.Empty) }/swagger/v1/swagger.json", "Facturacion.API V1");
            //       c.OAuthClientId("facturacionswaggerui");
            //       c.OAuthAppName("Facturacion Swagger UI");
            //   });

            app.UseRouting();

            app.UseEndpoints(endpoints => 
                { 
                    endpoints.MapControllers();
                    endpoints.MapDefaultControllerRoute();
                });

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //};

            //app.UseMvc();
        }
    }

    static class CustomExtensionsMethods
    {
        //public static IServiceCollection AddCustomMvc(this IServiceCollection services)
        //{
            // Add framework services.
        //    services.AddControllers(options =>
        //    {
        //        options.Filters.Add(typeof(HttpGlobalExceptionFilter));
        //    })
        //        // Added for functional tests
        //        .AddApplicationPart(typeof(ComisionesController).Assembly)
        //        .AddNewtonsoftJson()
        //        .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
        //    ;

        //    services.AddCors(options =>
        //    {
        //        options.AddPolicy("CorsPolicy",
        //            builder => builder
        //            .SetIsOriginAllowed((host) => true)
        //            .AllowAnyMethod()
        //            .AllowAnyHeader()
        //            .AllowCredentials());
        //    });

        //    return services;
        //}

        public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkSqlServer()
                   .AddDbContext<FacturacionContext>(options =>
                   {
                        options.UseSqlServer(configuration["ConnectionString"],
                           sqlServerOptionsAction: sqlOptions =>
                           {
                               sqlOptions.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name);
                               sqlOptions.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                           });
                   },
                       ServiceLifetime.Scoped  //Showing explicitly that the DbContext is shared across the HTTP request scope (graph of objects started in the HTTP request)
                   );

            return services;
        }

    }
}
