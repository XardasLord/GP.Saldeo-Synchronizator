﻿using System;
using System.Reflection;
using AutoMapper;
using Coravel.Pro;
using GP.SS.Api.Mappings;
using GP.SS.Business;
using GP.SS.Business.Jobs;
using GP.SS.Database;
using GP.SS.Infrastructure.SaldeoSmart;
using GP.SS.Infrastructure.SaldeoSmart.Configuration;
using GP.SS.Infrastructure.SaldeoSmart.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GP.SS.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IServiceProvider services)
        {
            Configuration = configuration;
            Services = services;
        }

        public IConfiguration Configuration { get; }
        public IServiceProvider Services { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SaldeoSynchronizatorContext>(
                opts => opts.UseOracle(Configuration.GetConnectionString("SaldeoSynchronizatorDB"),
                    b => b.MigrationsAssembly(typeof(SaldeoSynchronizatorContext).Namespace))
            );

            services.AddTransient<ISynchronizationService, SynchronizationService>();
            services.AddTransient<ISaldeoSmartFacade, SaldeoSmartFacade>();
            services.AddTransient<ISaldeoSmartAuthorizationHelper, SaldeoSmartAuthorizationHelper>();
            services.AddTransient<SynchronizeSaldeoCompaniesJob>();
            services.AddTransient<SynchronizeSaldeoContractorsJob>();
            services.AddTransient<SynchronizeSaldeoDocumentsJob>();

            services.Configure<SaldeoSmartSettings>(Configuration.GetSection("SaldeoSmartSettings"));

            services.AddAutoMapper(typeof(BusinessMappers).GetTypeInfo().Assembly);

            services.AddCoravelPro(typeof(SaldeoSynchronizatorContext));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCoravelPro();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
