using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
    internal class UserEntityConfigurations : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.SurName)
               .IsRequired()
               .HasMaxLength(255);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.SecName)
            .IsRequired()
            .HasMaxLength(255);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
