using System.ComponentModel.DataAnnotations.Schema;

namespace MealsRestaurant.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }


        public decimal TotalPrice  { get; set; }
        public decimal? TotalPriceAfterDiscount { get; set;}

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }

    }
}
