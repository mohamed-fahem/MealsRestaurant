using System.ComponentModel.DataAnnotations.Schema;

namespace MealsRestaurant.Models
{
    public class Ad
    {
        public int AdId { get; set; }
        public string AdImage { get; set; }
        public string Url { get; set; }

        
        public int MealId { get; set; }
        [ForeignKey("MealId")]
        public Meal Meal { get; set; }
    }
}
