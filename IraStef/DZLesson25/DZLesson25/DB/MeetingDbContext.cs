using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DZLesson25.DB
{
    public class MeetingDbContext(DbContextOptions<MeetingDbContext> options) : DbContext(options)
    {
        public MeetingDbContext() : this(new DbContextOptions<MeetingDbContext>()) { }
        public DbSet<User> Users { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<UsersInMeeting> UsersInMetings { get; set; } 
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeetingDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
