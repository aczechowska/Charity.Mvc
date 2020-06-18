using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Context;
using Charity.Mvc.Services;
using Charity.Mvc.Services.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Charity.Mvc
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup()
		{
			var configBuilder = new ConfigurationBuilder();
			configBuilder.AddJsonFile("appsettings.json");
			Configuration = configBuilder.Build();
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();

			//services.AddControllersWithViews();
			//services.AddRazorPages();

			services.AddDbContext<CharityContext>(builder =>
			{
				builder.UseSqlServer(Configuration["Database:ConnectingString"]);
			});

			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IInstitutionService, InstitutionService>();
			services.AddScoped<IDonationService, DonationService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseBrowserLink();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
