using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Acme.BookStore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOrchardCms();

            services.AddCors(options =>
            {
                options.AddPolicy(name: "clients",
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:44307",
                                            "http://localhost:44307");
                    });
            });
        }
        
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseCors("clients");

            app.UseStaticFiles();
            app.UseOrchardCore();
        }
    }
}
