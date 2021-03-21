using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using WebFamilies_Assignment.Authentication;
using WebFamilies_Assignment.Data;
using WebFamilies_Assignment.Data.Implementation;


namespace Families
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<PieChartData>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<InterfaceUserService, ImplementationUserService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddSingleton<InterfaceAdultsData, ImplementationAdultsData>();
            services.AddSingleton<InterfaceChildrenData, ImplementationChildrenData>();
            
            services.AddAuthorization(options =>
            {
                options.AddPolicy("MustBeAdministrator", a =>
                    a.RequireAuthenticatedUser().RequireClaim("Role","Administrator"));
                options.AddPolicy("SecurityLevel3", a =>
                    a.RequireAuthenticatedUser().RequireClaim("SecurityLevel","3", "4", "5"));

            });
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}