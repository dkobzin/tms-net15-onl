using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DZLesson25.DB.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(t => t.Id);
            entity.HasMany(t => t.usersInMeetings).WithOne(t => t.User).HasForeignKey(t => t.IdUser);
        }
    }
}
