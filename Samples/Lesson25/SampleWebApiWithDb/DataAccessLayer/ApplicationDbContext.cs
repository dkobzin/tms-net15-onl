using DataAccessLayer.Configations;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<WeatherForecastEntity> WeatherForecastEntities { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ManagerEntity> Managers { get; set; }

        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //modelBuilder.ApplyConfiguration(new WeatherForecastConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }
    }
}
