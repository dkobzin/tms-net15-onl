using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DZLesson25.DB.Configuration
{
    public class UserInMeetingConfiguration : IEntityTypeConfiguration<UsersInMeeting>
    {
        public void Configure(EntityTypeBuilder<UsersInMeeting> entity)
        {
            entity.HasKey(x => new { x.IdMeeting, x.IdUser });
        }
    }
}
