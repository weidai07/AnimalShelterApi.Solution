using AnimalShelterApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
// using Microsoft.OpenApi.Models;

namespace AnimalShelterApi
{
  public class Startup
    {
//         public Startup(IConfiguration configuration)
//         {
//             Configuration = configuration;
//         }

//         public IConfiguration Configuration { get; }

//         public void ConfigureServices(IServiceCollection services)
//         {
//             services.AddDbContext<AnimalShelterApiContext>(opt =>
//                 opt.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
//             services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

//             services.AddSwaggerGen(c =>
//             {
//                 c.SwaggerDoc("v1", new OpenApiInfo { Title = "AnimalShelterApi", Version = "v1" });
//             }); 
//         }

//         public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//             else
//             { 
//                 app.UseHsts();
//             }
//             app.UseSwagger(); 

//             app.UseSwaggerUI(c =>
//             {
//                 c.SwaggerEndpoint("/swagger/v1/swagger.json", "AnimalShelterApi V1");
//             }); 
            
//             app.UseMvc();
//         }
    }
}