using Ecommerce.DAL.Configurations;
using Ecommerce.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DAL.Context
{
    public class ECommerceContext : IdentityDbContext<AppUser, AppUserRole, Guid>
    {
        //DbSets

        //Category DbSet
        public DbSet<Category> Categories { get; set; }
        //Product DbSet
        public DbSet<Product> Products { get; set; }
        //Supplier DbSet
        public DbSet<Supplier> Suppliers { get; set; }

        //OnConfiguring todo: UI katmanı eklenince bağlantı servisler üzerine Json yapısıyla beraber verilecek.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=RIP;database=ECommerceProject;Trusted_Connection=True;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //CategoryConfigurations
            builder.ApplyConfiguration(new CategoryConfigurations());

            //ProductConfigurations
            builder.ApplyConfiguration(new ProductConfiguration());

            //SupplierConfigurations
            builder.ApplyConfiguration(new SupplierConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
