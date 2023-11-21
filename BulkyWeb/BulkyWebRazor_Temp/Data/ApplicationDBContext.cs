using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BulkyWebRazor_Temp.Data
{
        public class ApplicationDBContext : DbContext
        {
            public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
            {
            }

            public DbSet<Category> Razor_Categories { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { CategoryId = 2, Name = "Science Fiction", DisplayOrder = 2 },
                    new Category { CategoryId = 3, Name = "History", DisplayOrder = 3 }
                    );
            }
        }
}
