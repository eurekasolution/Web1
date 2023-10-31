using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Web1.Models;

using Microsoft.Extensions.Logging;
using System.Data.Common;

namespace Web1
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Logging.AddConsole();

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            try
            {
                return Host.CreateDefaultBuilder(args)
                        .ConfigureWebHostDefaults(webBuilder =>
                        {
                            webBuilder.UseStartup<Startup>();
                        })
                        .UseDefaultServiceProvider(options =>
                            options.ValidateScopes = false)
                        .ConfigureServices((context, services) =>
                        {
                            services.AddDbContext<Web1DbContext>(options =>
                            {
                                //var connectionString = context.Configuration.GetConnectionString("MyDbContext");
                                var connectionString = "Server=localhost;Port=3306;Database=csharp;User=csharp;Password=csharp;";
                                options.UseMySql(connectionString, ServerVersion.AutoDetect("DefaultConnection"));
                            }).AddScoped<Web1DbContext>();
                        });
            }
            catch (Exception ex)
            {
                // 에러 로깅 또는 디버깅 메시지를 여기에 추가
                Console.WriteLine($"Error in CreateHostBuilder: {ex.Message}");
                throw;
            }
        }
    }
}