using DenemeProje.Web.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace DenemeProje.Web.Data
{
    public class AlicanDbContext : DbContext
    {
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }

        public AlicanDbContext(DbContextOptions<AlicanDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categories>().HasKey("CategoryID");
            modelBuilder.Entity<Customers>().HasKey("CustomerID");
        }
    }
}
