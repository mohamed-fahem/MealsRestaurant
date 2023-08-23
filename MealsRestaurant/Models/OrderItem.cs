namespace MealsRestaurant.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int MealId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Meal Meal { get; set; }

    }
}
