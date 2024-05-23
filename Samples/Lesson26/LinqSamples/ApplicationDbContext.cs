using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace LinqSamples;

public class ApplicationDbContext : DbContext
{
    public DbSet<Pinguin> Pinguins => Set<Pinguin>();
    public DbSet<LittlePinguin> LittlePinguins => Set<LittlePinguin>();
    

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
        modelBuilder.Entity<Pinguin>()
            .ToTable("penguins");
        
        modelBuilder.Entity<Pinguin>()
            .HasKey(p => p.Id);
        
        modelBuilder.Entity<Pinguin>()
            
        modelBuilder.Entity<Pinguin>()
            .Property(p => p.Species);
        
        modelBuilder.Entity<Pinguin>()
            .Property(p => p.Island);
        
        modelBuilder.Entity<Pinguin>()
            .Property(p => p.BillDepthMm);
        
        modelBuilder.Entity<Pinguin>()
            .Property(p => p.BodyMassG);

        modelBuilder.Entity<Pinguin>()
            .Property(p => p.BillLengthMm);
        
        modelBuilder.Entity<Pinguin>()
            .Property(p => p.FlipperLengthMm);


        modelBuilder.Entity<LittlePinguin>()
            .ToTable("little_penguins");

        modelBuilder.Entity<LittlePinguin>()
            .HasKey(p => p.Id);
        
        modelBuilder.Entity<LittlePinguin>()
            .Property(p => p.Species);
        
        modelBuilder.Entity<LittlePinguin>()
            .Property(p => p.Island);
        
        modelBuilder.Entity<LittlePinguin>()
            .Property(p => p.BillDepthMm);
        
        modelBuilder.Entity<LittlePinguin>()
            .Property(p => p.BodyMassG);

        modelBuilder.Entity<LittlePinguin>()
            .Property(p => p.BillLengthMm);
        
        modelBuilder.Entity<LittlePinguin>()
            .Property(p => p.FlipperLengthMm);
        
    }
}