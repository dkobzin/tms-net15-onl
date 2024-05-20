using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>, IDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var configurationBuilder = new ConfigurationBuilder();
        var configuration = configurationBuilder
            .AddJsonFile("appsettings.json")
            .Build();

        DbContextOptionsBuilder<ApplicationDbContext> contextOptionsBuilder = new();
        var connectionString = configuration.GetConnectionString("DefaultConnection") ??
                               throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        contextOptionsBuilder
            .UseLazyLoadingProxies() // Lazy Loading
            //.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll) // Tracking
            //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking) // NoTracking
            .UseSqlServer((string?)connectionString, options => options.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null));

        return new ApplicationDbContext(contextOptionsBuilder.Options);
    }

    public ApplicationDbContext CreateDbContext()
    {
        return CreateDbContext([]);
    }
}