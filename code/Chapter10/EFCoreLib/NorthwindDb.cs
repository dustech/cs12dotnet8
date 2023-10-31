using System.Data.Common;
using Microsoft.EntityFrameworkCore; // To use DbContext and so on.


namespace Northwind.EntityModels;

public class NorthwindDb : DbContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    base.OnConfiguring(optionsBuilder);

    var dbFile = "Northwind.db";
    var dbPath = Path.Combine(Environment.CurrentDirectory, dbFile);
    string connectionString = "Data Source=Northwind.db;Version=3;";
    WriteLine($"Connection: {connectionString}");

    optionsBuilder.UseSqlite(connectionString);


  }
}