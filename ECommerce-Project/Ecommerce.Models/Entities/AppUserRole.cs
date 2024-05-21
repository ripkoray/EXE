using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Models.Entities
{
    public class AppUserRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
