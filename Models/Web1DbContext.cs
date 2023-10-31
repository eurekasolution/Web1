// Web1DbContext.cs
using Microsoft.EntityFrameworkCore;
using Web1.Pages;
using Web1.Models;
using Microsoft.Extensions.Configuration;
using System;


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
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    _configuration.GetConnectionString("DefaultConnection"),
                    ServerVersion.AutoDetect(_configuration.GetConnectionString("DefaultConnection"))
                );
            }
        }
        /*
        public Web1DbContext(DbContextOptions<Web1DbContext> options) : base(options)
        {
        }
        */
        // DbSet에 모델 클래스 추가
        public DbSet<User> User { get; set; }

    }
}