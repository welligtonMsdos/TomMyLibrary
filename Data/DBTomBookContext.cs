using Microsoft.EntityFrameworkCore;
using TomMyLibrary.Models;

namespace TomMyLibrary.Data;

public class DBTomBookContext : DbContext
{
    public DBTomBookContext(DbContextOptions<DBTomBookContext> options) : base(options)
    {            
    }

    public DbSet<Library> libraries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Library>()
            .Property(e => e.datacreate)
            .HasColumnType("timestamptz");
    }
}
