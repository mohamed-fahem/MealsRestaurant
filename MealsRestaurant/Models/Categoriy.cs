using System.ComponentModel.DataAnnotations;

namespace MealsRestaurant.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; }


        public string CategoryImage { get; set; }


        public virtual ICollection<Meal>Meals { get; set; }
        
    }
}
