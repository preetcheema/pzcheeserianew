using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PzCheeseria.Persistence.Infrastructure;

public class PZCheeseriaContextFactory:IDesignTimeDbContextFactory<PzCheeseriaContext>
{
    private const string ConnectionStringName = "PZCheeseriaConnectionString";

        
    public PzCheeseriaContext CreateDbContext(string[] args)
    {
        var basePath = Directory.GetCurrentDirectory() + string.Format("{0}..{0}PZCheeseria.Api", Path.DirectorySeparatorChar);

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.Local.json", optional: true)
            .Build();

        var connectionString = configuration.GetConnectionString(ConnectionStringName);

        var optionsBuilder = new DbContextOptionsBuilder<PzCheeseriaContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new PzCheeseriaContext(optionsBuilder.Options);
    }
}
