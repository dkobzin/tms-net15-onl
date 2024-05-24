using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    internal class MeetingEntityConfigurations : IEntityTypeConfiguration<MeetingEntity>
    {
        public void Configure(EntityTypeBuilder<MeetingEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(255);
          
            builder.Property(p => p.DateTime)
                .IsRequired();

            builder.HasOne(p => p.MeetingRoom)
                .WithMany()
                .HasForeignKey(p => p.IdRoom);
        }
    }
}
