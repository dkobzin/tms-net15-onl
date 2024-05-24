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
    internal class UserMeetingEntityConfigurations : IEntityTypeConfiguration<UserMeetingEntity>
    {
        public void Configure(EntityTypeBuilder<UserMeetingEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.User)
               .WithMany(p => p.Meetings)
               .HasForeignKey(p => p.IdUser);

            builder.HasOne(p => p.Meeting)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.IdMeeting);              
        }
    }
}
