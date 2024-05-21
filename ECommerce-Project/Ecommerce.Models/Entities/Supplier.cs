using Ecommerce.Models.Base;

namespace Ecommerce.Models.Entities
{
    public class Supplier : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }

        //Mapping

        public List<Product> Products { get; set; }
    }
}
