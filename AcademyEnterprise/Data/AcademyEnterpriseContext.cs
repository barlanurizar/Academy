using Microsoft.EntityFrameworkCore;
using AcademyEnterprise.Models;
using Enrollment = AcademyEnterprise.Models.Enrollment;

namespace AcademyEnterprise.Data
{
    public class AcademyEnterpriseContext : DbContext
    {
        public AcademyEnterpriseContext (DbContextOptions<AcademyEnterpriseContext> options)
            : base(options)
        {
        }

        public DbSet<AcademyEnterprise.Models.Product> Product { get; set; }
        public DbSet<AcademyEnterprise.Models.Employee> Employee { get; set; }
        public DbSet<AcademyEnterprise.Models.Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Product>().ToTable("Product");
        }

        public DbSet<AcademyEnterprise.Models.Enrollment> Enrollment { get; set; }

        
    }
}
