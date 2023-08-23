namespace MealsRestaurant.Models
{
    public class MealSubscription
    {
        public int MealSubscriptionId { get; set; }
        public int MealId { get; set; }
        public int SubscriptionId { get; set; }

        public virtual Meal Meal { get; set; }
        public virtual Subscription Subscription { get; set; }

    }
}
