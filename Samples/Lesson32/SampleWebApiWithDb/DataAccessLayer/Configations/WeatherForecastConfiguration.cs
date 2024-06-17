using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configations;

public class WeatherForecastConfiguration : IEntityTypeConfiguration<WeatherForecastEntity>
{
    public void Configure(EntityTypeBuilder<WeatherForecastEntity> builder)
    {
        builder.ToTable("WeatherForecasts");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Date)
            .IsRequired();

        builder.Property(p => p.TemperatureC)
            .IsRequired();

        builder.Property(p => p.Summary)
            .HasMaxLength(255);
    }
}