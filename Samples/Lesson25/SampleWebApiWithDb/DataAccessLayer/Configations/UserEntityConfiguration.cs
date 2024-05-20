using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configations;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(p =>p.AskedWeatherForeCast);

        /*builder.HasOne<AddressEntity>(p => p.Address)
            .WithOne(t => t.User)
            .HasForeignKey<AddressEntity>(k => k.UserId);*/
        
        builder.HasMany<AddressEntity>(p => p.Addresses)
            .WithOne(t => t.User)
            .HasForeignKey(k => k.UserId);
    }
}