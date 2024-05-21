using Ecommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.DAL.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           
            //Property Customize
            builder.Property(x => x.CategoryName).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(SeedCategoryData);
        }

        //Category Data

        private List<Category> SeedCategoryData()
        {
            List<Category> categories = new List<Category>();

            categories.Add(new Category
            {
                ID = 1,
                CategoryName = "TestCategory1",
                Description = "TestCategoryDescription1"
            });

            categories.Add(new Category
            {
                ID = 2,
                CategoryName = "TestCategory2",
                Description = "TestCategoryDescription2"
            });

            categories.Add(new Category
            {
                ID = 3,
                CategoryName = "TestCategory3",
                Description = "TestCategoryDescription3"
            });

            return categories;
        }
    }
}
