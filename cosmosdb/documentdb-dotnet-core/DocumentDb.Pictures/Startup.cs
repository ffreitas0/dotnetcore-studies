﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DocumentDb.Pictures.Models;
using Sakura.AspNetCore.Mvc;
using DocumentDb.Pictures.Data;
using DocumentDb.Pictures.Mappings;

namespace DocumentDb.Pictures
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            Config.WebRootPath = env.WebRootPath;
            Config.ContentRootPath = env.ContentRootPath;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IDocumentDBRepository<GalleryDBRepository>, GalleryDBRepository>();
            
            // Add framework services.
            services.AddMvc();

            // Add default bootstrap-styled pager implementation
            services.AddBootstrapPagerGenerator(options =>
            {
                // Use default pager options.
                options.ConfigureDefault();
            });

            // Make Configuration injectable
            services.AddSingleton<IConfiguration>(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            AutoMapperConfiguration.Configure();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Pictures}/{action=Index}/{id?}");
            });

            //DocumentDBRepository<PictureItem>.Initialize();
            DocumentDBInitializer.Initialize(Configuration);
        }
    }
}
