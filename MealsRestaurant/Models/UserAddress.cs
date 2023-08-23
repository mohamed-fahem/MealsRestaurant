using System.ComponentModel.DataAnnotations.Schema;

namespace MealsRestaurant.Models
{
    public class UserAddress
    {
        public int UserAddressId { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public int HomeNumber { get; set; }
        public int Lang { get; set; }
        public int Late { get; set; }

        
        public string UserId { get; set; }


        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }


    }
}
