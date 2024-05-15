using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<WeatherForecastEntity> WeatherForecastEntities;

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
            modelBuilder.Entity<WeatherForecastEntity>()
                .ToTable("WeatherForecasts");

            modelBuilder.Entity<WeatherForecastEntity>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<WeatherForecastEntity>()
                .Property(p => p.Date)
                .IsRequired();
            
            modelBuilder.Entity<WeatherForecastEntity>()
                .Property(p => p.TemperatureC)
                .IsRequired();
            
            modelBuilder.Entity<WeatherForecastEntity>()
                .Property(p => p.Summary)
                .HasMaxLength(255);
        }
    }
}
