using Northwind.EntityModels; // to use Northwind db


using NorthwindDb db = new();

WriteLine($"Provider: {db.Database.ProviderName}");

// Disposes the database context.

var c = db.Category.First();

WriteLine($"My cat: {c.CategoryId}");