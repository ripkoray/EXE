using Bogus;
using Ecommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Fluent Api
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Supplier).WithMany(x => x.Products).HasForeignKey(x => x.SupplierId);

            //Property Customize
            builder.Property(x => x.ProductName).HasMaxLength(255);
            builder.Property(x => x.ProductName).IsRequired(true);

            //HasData
            builder.HasData(SeedProductData);
        }

        //Product Data
        private List<Product> SeedProductData()
        {

            var fakeData = new Faker(); //Bogus
            List<Product> products = new List<Product>();

            for (int i = 1; i < 4; i++)
            {
                for (int z = 1; z < 12; z++)
                {
                    Product product = new Product();
                    product.ID = i * 100 + z;
                    product.CategoryId = i;
                    product.SupplierId = i;
                    product.UnitPrice = decimal.Parse(fakeData.Commerce.Price(min: 10, max: 1000, 2));
                    product.UnitsInStock = fakeData.Random.Short(min: 1, max: 100);
                    product.ImagePath = fakeData.Image.PicsumUrl();
                    products.Add(product);
                }
            }
            return products;
        }
    }
}
