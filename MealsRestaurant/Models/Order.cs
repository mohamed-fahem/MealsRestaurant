using System.ComponentModel.DataAnnotations.Schema;

namespace MealsRestaurant.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal? PriceDiscount { get; set; }
        public decimal FinalPrice { get; set;}

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }

    }
}
