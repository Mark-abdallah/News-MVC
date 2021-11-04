using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Seeding categories initial values
            builder.Entity<Category>().HasData(
          new Category { Id=1 , CategoryType="Magazin"},
          new Category { Id = 2 , CategoryType = "Business"},
          new Category { Id = 3 , CategoryType = "Sports"},
          new Category { Id = 4 , CategoryType = "Art"},
          new Category { Id = 5, CategoryType = "Politics" },
          new Category { Id = 6, CategoryType = "Travel" }
            );
            
            //defult value for the post time
            builder.Entity<News>().Property(c => c.PostedAt).HasDefaultValueSql("GETDATE()");
            base.OnModelCreating(builder);
        }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<NewsVM> NewsVMs { get; set; }

    }
}
