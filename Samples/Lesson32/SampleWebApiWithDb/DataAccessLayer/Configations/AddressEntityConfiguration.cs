using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configations
{
    public class AddressEntityConfiguration : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.ToTable("Addresses");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Country)
                .HasMaxLength(32);

            builder.Property(p => p.City)
                .HasMaxLength(32);

            builder.Property(p => p.Street)
                .HasMaxLength(32);
            
            builder.Property(p => p.Appartment)
                .HasMaxLength(32);

            /* builder.HasOne<UserEntity>(p => p.User)
                .WithOne(t => t.Address)
                .HasForeignKey<UserEntity>(k => k.AddressId); */
            
            builder.HasOne<UserEntity>(p => p.User)
                //.WithMany(t => t.Addresses)
                //.HasForeignKey(k => k.UserId)
                ;

        }
    }
}
