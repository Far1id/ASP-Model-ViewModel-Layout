using ASP_Database_connection.Models;
using ASP_Database_connection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Database_connection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Id = 1,
                    Image = "slide-1.jpg",
                    BlackTitle = "Ferid Cahangirli",
                    RedTitle2 = " 1 ",
                    Text = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",
                    BtnText = "Click eleme",
                    BtnUrl = "https://pbs.twimg.com/profile_images/1315057774020243456/JGbk5ZZY_400x400.jpg"
                },
                new Slider
                {
                    Id = 2,
                    Image = "slide-2.jpg",
                    BlackTitle = "Ferid Cahangirli",
                    RedTitle2 = " 2 ",
                    Text = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",
                    BtnText = "Click eleme",
                    BtnUrl = "https://pbs.twimg.com/profile_images/1315057774020243456/JGbk5ZZY_400x400.jpg"
                },
                new Slider
                {
                    Id = 3,
                    Image = "slide-3.jpg",
                    BlackTitle = "Ferid Cahangirli",
                    RedTitle2 = " 3 ",
                    Text = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",
                    BtnText = "Click eleme",
                    BtnUrl = "https://pbs.twimg.com/profile_images/1315057774020243456/JGbk5ZZY_400x400.jpg"
                },
            };

            List<Service> services = new List<Service>
            {
                new Service
                {
                    Id=1,
                    Icon = "bx bxl-dribbble",
                    Title = "Ferid",
                    Text = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },
                new Service
                {
                    Id=2,
                    Icon = "bx bx-file",
                    Title = "Ferid",
                    Text = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },
                new Service
                {
                    Id=3,
                    Icon = "bx bx-tachometer",
                    Title = "Ferid",
                    Text = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },
                new Service
                {
                    Id=4,
                    Icon = "bx bxl-dribbble",
                    Title = "Ferid",
                    Text = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },
                new Service
                {
                    Id=5,
                    Icon = "bx bx-file",
                    Title = "Ferid",
                    Text = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },
                new Service
                {
                    Id=6,
                    Icon = "bx bx-tachometer",
                    Title = "Ferid",
                    Text = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                }
              
            };

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = sliders,
                Services = services
            };
            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
