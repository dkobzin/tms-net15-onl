using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DZLesson25.DB.Configuration
{
    public class MeetingConfiguration : IEntityTypeConfiguration<Meeting>
    {
        public void Configure(EntityTypeBuilder<Meeting> entity)
        {
            entity.HasKey(t => t.Id);
            entity.HasOne(t => t.Room).WithMany().HasForeignKey(t => t.Id);
            entity.HasMany(t => t.usersInMeetings).WithOne(t => t.Meeting).HasForeignKey(t => t.IdMeeting);
        }
    }
}
