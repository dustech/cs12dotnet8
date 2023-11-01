using System.Data.Common;
using EntityModels;
using Microsoft.EntityFrameworkCore; // To use DbContext and so on.


namespace Northwind.EntityModels;

public class NorthwindDb : DbContext
{
  public DbSet<Category> Category { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    base.OnConfiguring(optionsBuilder);

    var dbFile = "Northwind.db";
    var dbPath = Path.Combine(Environment.CurrentDirectory, dbFile);
    string connectionString = "Data Source=Northwind.db;";
    WriteLine($"Connection: {connectionString}");

    optionsBuilder.UseSqlite(connectionString);


  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    //modelBuilder.Entity<Category>()


  }
}


