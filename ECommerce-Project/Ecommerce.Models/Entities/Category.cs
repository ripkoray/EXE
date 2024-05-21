﻿using Ecommerce.Models.Base;

namespace Ecommerce.Models.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Mapping
        public List<Product> Products { get; set; }
    }
}
