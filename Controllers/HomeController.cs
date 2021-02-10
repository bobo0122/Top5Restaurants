using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Top5Restaurants.Models;

namespace Top5Restaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("List")] //how to do take you straight to the /list 
        public IActionResult RestaurantList()
        {

            //declare the variable
            List<string> restaurantList = new List<string>();
            //List<string> banList = new List<string>();
            foreach (Restaurant b in Restaurant.GetRestaurants())
            {
                //?? What to put instead of the ranking, then following with 999
             //  string? fav = b.FavoriteDish ?? "It's all tasty!";
               
                restaurantList.Add(string.Format("#{0}: {1} | {2} | {3} | {4} | {5} ", b.RestaurantRanking, b.RestaurantName, b.FavoriteDish, b.Address, b.RestaurantPhone, b.LinktoWebsite));
            }
            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult AddFav()
        {
            return View();

        }

        [HttpPost]
        public IActionResult AddFav(ApplicationResponse appResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(appResponse);
                return View("Confirmation", appResponse);
            }
            else
            {
                return View();
            }

        }


        public IActionResult SubmittedList()
        {
            return View(TempStorage.Applications);

        }
        public IActionResult Confirmation()
        {
            return View();
        }

       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
