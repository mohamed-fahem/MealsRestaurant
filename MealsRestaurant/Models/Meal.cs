using System.ComponentModel.DataAnnotations.Schema;

namespace MealsRestaurant.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string MealName { get; set;}
        public string MealImage { get; set; }
        public decimal MealPrice { get; set; }
        public decimal? MealPriceDiscount { get; set; }

        
        public int CategoriyId { get; set; }
        [ForeignKey("CategoriyId")]
        public Categoriy Categoriy { get; set; }
        public virtual ICollection<OrderItem> Orders { get; set; }
        public virtual ICollection<MealSubscription> Subscriptions { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }
    }
}
