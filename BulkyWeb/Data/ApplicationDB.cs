using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDB : DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options) 
        {
               
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "action", Display = 1 },
                new Category { CategoryId = 2, Name = "action", Display = 2 },
                new Category { CategoryId = 3, Name = "action", Display = 3 }
                
                );
        }
    }
}
