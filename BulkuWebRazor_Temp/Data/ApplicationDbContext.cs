using BulkuWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkuWebRazor_Temp.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
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
