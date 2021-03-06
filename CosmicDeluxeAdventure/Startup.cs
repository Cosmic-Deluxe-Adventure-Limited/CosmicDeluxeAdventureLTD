using CosmicDeluxeAdventure.Data;
using CosmicDeluxeAdventure.Model.Interfaces;
using CosmicDeluxeAdventure.Model.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
//Needed for database (install NUGET)
using Microsoft.EntityFrameworkCore;
//
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CosmicDeluxeAdventure
{
  public class Startup
  {
    public IConfiguration Configuration { get; }
    private bool _startReact = true;
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;      
    }
    

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {

      services.AddControllersWithViews();
      //Initial DB setup
      services.AddDbContext<CADDbContext>(options =>
      {
        string connectionString = Configuration.GetConnectionString("DefaultConnection");
        options.UseSqlServer(connectionString);
      });
      services.AddMvc();
      //Swagger UI - Comment to disable Swagger
      services.AddSwaggerGen();
      //      
      services.AddTransient<IUserInfo, UserInfoService>();
      services.AddTransient<IFlight, FlightService>();

      // In production, the React files will be served from this directory
      services.AddSpaStaticFiles(configuration =>
      {
        configuration.RootPath = "ClientApp/build";
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
      //REACT FRONTEND
      if (_startReact)
      {
        app.UseSpaStaticFiles();
      }
      //END REACT BLOCK
      //Comment Block to Disable Swagger
      else
      {
        app.UseSwagger(//options =>

        );
        app.UseSwaggerUI(c =>
        {
          c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cosmic Adventure Deluxe V0.1");
          c.RoutePrefix = string.Empty;
        });
      }
      // END SWAGGER BLOCK
      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller}/{action=Index}/{id?}");
      });
      //REACT FRONTEND
      if (_startReact)
      {
        app.UseSpa(spa =>
        {
          spa.Options.SourcePath = "ClientApp";

          if (env.IsDevelopment())
          {
            //Use if needed to manually start the React Server First.
            //spa.UseProxyToSpaDevelopmentServer("http://localhost:3000");
            spa.UseReactDevelopmentServer(npmScript: "start");
          }
        });
      }
      // END REACT BLOCK
    }
  }
}

