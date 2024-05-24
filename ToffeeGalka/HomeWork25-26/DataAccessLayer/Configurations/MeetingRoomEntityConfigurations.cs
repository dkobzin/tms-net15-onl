using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Configurations
{
    internal class MeetingRoomEntityConfigurations : IEntityTypeConfiguration<MeetingRoomEntity>
    {
        public void Configure(EntityTypeBuilder<MeetingRoomEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(255);
        }
    }
}
