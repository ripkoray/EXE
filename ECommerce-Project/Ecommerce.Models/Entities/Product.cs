using Ecommerce.Models.Base;

namespace Ecommerce.Models.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string ImagePath { get; set; }

        //Mapping
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
