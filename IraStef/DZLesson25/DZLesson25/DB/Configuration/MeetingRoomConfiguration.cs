using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DZLesson25.DB.Configuration
{
    public class MeetingRoomConfiguration : IEntityTypeConfiguration<MeetingRoom>
    {
        public void Configure(EntityTypeBuilder<MeetingRoom> entity)
        {
            entity.HasKey(t => t.Id);
        }
    }
}
