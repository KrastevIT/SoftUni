using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data
{
    public class GameStoreDbContext : DbContext
    {
        public DbSet<Game> GameStores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=GameStoreDb;Integrated Security=True;");
        }
    }
}
