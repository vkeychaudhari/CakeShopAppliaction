using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CakeShop.Domain.Models;

namespace CakeShop.EntityFramework
{
    public class CakeShopDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQlLocalDB;Database=CakeShopDB;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
