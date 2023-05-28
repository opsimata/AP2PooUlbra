// using Domain.Entities;
// using Microsoft.EntityFrameworkCore;

// namespace Data
// {
//     public class DataContext : DbContext
//     {
//         public string DbPath { get; }
//         // public DbSet<Person> People { get; set; }
//         // public DbSet<Product> Products { get; set; }
//         // public DbSet<City> Cities { get; set; }

//         public DataContext()
//         {
//             string path = Directory.GetCurrentDirectory(); // Get no local da gravação do DB
//             DbPath = System.IO.Path.Join(path, "BankAPII.db"); // Concatena o path ao nome do DB
//         }

//         protected override void OnConfiguring(DbContextOptionsBuilder options)
//             => options.UseSqlite($"Data Source={DbPath}");
//     }
// }