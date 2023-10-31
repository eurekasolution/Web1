using Microsoft.EntityFrameworkCore;

namespace Web1.Models
{
    public class Web1DbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public Web1DbContext()
        {

        }

        public Web1DbContext(DbContextOptions<Web1DbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    _configuration.GetConnectionString("MyConnection"),
                    ServerVersion.AutoDetect(_configuration.GetConnectionString("MyConnection"))
                );
            }
        }
    }
}
