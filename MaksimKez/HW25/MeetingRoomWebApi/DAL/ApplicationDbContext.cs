using System.Reflection;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MeetingEntity> Meetings { get; set; }
        public DbSet<MeetingRoomEntity> Rooms { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=LAPTOP-4V6DC9VL\MSSQLSERVER02;Database=HW25;User Id=sa_hw25;Password=SuperPassword123;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
