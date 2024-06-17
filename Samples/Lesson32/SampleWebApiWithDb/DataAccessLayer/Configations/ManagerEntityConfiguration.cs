using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configations;

public class ManagerEntityConfiguration : IEntityTypeConfiguration<ManagerEntity>
{
    public void Configure(EntityTypeBuilder<ManagerEntity> builder)
    {
        // TPH - comment next code row
         builder.ToTable("Managers"); // TPT

        builder.Property(p => p.Role);
    }
}