using MealsRestaurant.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MealsRestaurant.Context
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Categoriy> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<MealSubscription> MealSubscriptions { get; set; }
        public DbSet<UserCard> UserCards { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
    }
}
