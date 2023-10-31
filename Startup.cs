using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Web1.Models;


namespace Web1
{
    public class Startup
    {
        public string connectionString = "Server=localhost;Port=3306;Database=csharp;User=csharp;Password=csharp;";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // 이 메서드에서 서비스 등록을 수행합니다.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Web1DbContext>(options =>
                    options.UseMySql(
                        Configuration.GetConnectionString("DefaultConnection"),
                        ServerVersion.AutoDetect(
                            Configuration.GetConnectionString("DefaultConnection")
                        )
                    )
            );

            services.AddSingleton<Web1DbContext>();

        }

        // 이 메서드에서 HTTP 요청 파이프라인을 구성합니다.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<Web1DbContext>();
                if (context == null)
                {
                    // `Web1DbContext` 타입의 서비스가 등록되지 않은 경우
                    throw new Exception("`Web1DbContext` 타입의 서비스가 등록되지 않았습니다.");
                }
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication(); // (옵션) 인증을 사용하는 경우
            app.UseAuthorization();  // (옵션) 권한 부여를 사용하는 경우

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}