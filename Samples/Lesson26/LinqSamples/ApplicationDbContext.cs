using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace LinqSamples;

public class ApplicationDbContext : DbContext
{
    public DbSet<Penguin> Pinguins => Set<Penguin>();
    public DbSet<LittlePenguin> LittlePinguins => Set<LittlePenguin>();
    

    protected ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(message => Debug.WriteLine(message));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}