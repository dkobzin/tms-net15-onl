using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Configurations;
using DataAccessLayer.Entities;
using System.Reflection;

namespace DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<MeetingEntity> Meetings { get; set; }
        public DbSet<MeetingRoomEntity> MeetingRooms { get; set; }
        public DbSet<UserMeetingEntity> UserMeetings { get; set; }
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
