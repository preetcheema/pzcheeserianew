using Microsoft.EntityFrameworkCore;
using PZCheeseria.Domain.Entities;

namespace PzCheeseria.Persistence;

public class PzCheeseriaContext : DbContext
{
    public PzCheeseriaContext(DbContextOptions<PzCheeseriaContext> options) : base(options)
    {

    }

    public DbSet<Cheese> Cheeses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PzCheeseriaContext).Assembly);
    }
}
