using Microsoft.AspNetCore.Identity;

namespace MealsRestaurant.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserCard> UserCards { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
   
}
