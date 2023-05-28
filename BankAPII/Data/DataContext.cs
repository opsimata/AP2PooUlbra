using BankAPII.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext : DbContext
    {
        public string DbPath { get; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BankAccount> Accounts { get; set; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory(); // Get no local da gravação do DB
            DbPath = System.IO.Path.Join(path, "BankAPII.db"); // Concatena o path ao nome do DB
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}