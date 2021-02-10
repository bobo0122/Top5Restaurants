using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable enable

namespace Top5Restaurants.Models
{
    public class Restaurant
    {
        public Restaurant(int ranking)
        {
            RestaurantRanking = ranking;
        }
 

        //this will be a null-able value, = 999 >> default value
        public int RestaurantRanking { get; }
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's all tasty!";
        public string Address { get; set; }
        public string? RestaurantPhone { get; set; }
        public string? LinktoWebsite { get; set; } = "Coming Soon";

        //a method for external class to get access to the list of bands


        public static Restaurant[] GetRestaurants()
        {
            Restaurant b1 = new Restaurant(1)
            {
                 RestaurantName = "Itto Sushi", 
                FavoriteDish = "Mafia Roll",
                Address = "547 E University Pkwy, Orem, UT",
                RestaurantPhone = "(385) 497-7045",
                LinktoWebsite = "https://ittoutah.com/"
            };

            Restaurant b2 = new Restaurant(2)
            {
                RestaurantName = "Aubergine Kitchen",
                FavoriteDish = "Veggie Pizza",
                Address = "1365 S State St, Orem, UT",
                RestaurantPhone = "(801)224-7484",
                LinktoWebsite = "https://aubergineandcompany.com/"
            };
            Restaurant b3 = new Restaurant(3)
            {
                RestaurantName = "Silver Dish Thai Cuisine",
               // FavoriteDish = "Massaman Curry",
                Address = "278 W Center St, Provo, UT",
                RestaurantPhone = "(801) 373-9540",
                LinktoWebsite = "https://silverdishthaicuisine.com/"
            };
            Restaurant b4 = new Restaurant(4)
            {
                RestaurantName = "Bombay House",
                FavoriteDish = "Vegetable Masala",
                Address = " 463 N University Ave, Provo, UT",
                RestaurantPhone = "(801) 373-6677",
               // LinktoWebsite = "https://bombayhouse.com/menu/"

            };
            Restaurant b5 = new Restaurant(5)
            {
                RestaurantName = "Umami Japanese Barbeque",
                FavoriteDish = "All you can eat",
                Address = "568 N Mill Rd suite 107, Vineyard, UT",
                RestaurantPhone = "(385) 329-0488",
                LinktoWebsite = "http://umamijapanesebbq.com/"

            };
            return new Restaurant[] { b1, b2, b3, b4, b5 };
        }
    }
}
