using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiHT25and26.Model;
using WebApiHT25and26.Model.IdentityModel;

namespace WebApiHT25and26.DataModel
{
    public class AppDbContexts : IdentityDbContext<Person>
    {
        public DbSet<LoginModel> Members => Set<LoginModel>();
        public AppDbContexts(DbContextOptions<AppDbContexts> options) : base(options)
        {
            //if (!Database.EnsureCreated())
            //{
            //    Database.EnsureCreated();
            //}
            //else
            //{
            //    Database.EnsureDeleted();
            //    Database.EnsureCreated();
            //}
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.OnModelCreating(builder);
            builder.Entity<LoginModel>().Ignore(prop => prop.Password);
            builder.Entity<IdentityUserLogin<string>>().HasNoKey();
            builder.Entity<IdentityUserRole<string>>().HasNoKey();
            builder.Entity<IdentityUserToken<string>>().HasNoKey();
        }
    }
}
