using System.ComponentModel.DataAnnotations.Schema;

namespace MealsRestaurant.Models
{
    public class UserCard
    {
        public int UserCardId { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public DateTime EndDate { get; set; }

        
        public string ApplicationUserId { get; set; }
        
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
