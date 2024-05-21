using Ecommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.DAL.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            //Property Customize
            builder.Property(x => x.CompanyName).IsRequired(true);
            builder.Property(x => x.Address).IsRequired(true);
            builder.Property(x => x.CompanyName).HasMaxLength(255);
            builder.Property(x => x.Address).HasMaxLength(255);

            //HasData
            builder.HasData(SeedSupplierData);

        }
        
        //Supplier Data
        private List<Supplier> SeedSupplierData()
        {
            List<Supplier> suppliers = new List<Supplier>();

            suppliers.Add(new Supplier
            {
                ID=1,
                CompanyName="TestSupplier1",
                Address="TestSupplierAdress1"
            });
            suppliers.Add(new Supplier
            {
                ID = 2,
                CompanyName = "TestSupplier2",
                Address = "TestSupplierAdress2"
            });
            suppliers.Add(new Supplier
            {
                ID = 3,
                CompanyName = "TestSupplier3",
                Address = "TestSupplierAdress3"
            });
            return suppliers;
        }
    }
}
