namespace MealsRestaurant.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionPrice { get; set; }
        public int NumberMeal { get; set; }
        public string SubscriptionImage { get; set; }
        public virtual ICollection<MealSubscription> Meal { get; set; }

    }
}
