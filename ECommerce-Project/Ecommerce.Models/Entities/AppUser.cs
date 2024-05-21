﻿using Ecommerce.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Models.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
    }
}
