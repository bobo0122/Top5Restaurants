using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Top5Restaurants.Models
{
    public class ApplicationResponse
    {
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        //prop tab tab builds the following:
        [Required(ErrorMessage = "Required")]
        public string RestaurantName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FavoriteDish { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid number, please re-enter . ")]
        public string RestaurantPhone { get; set; }

    }
}
