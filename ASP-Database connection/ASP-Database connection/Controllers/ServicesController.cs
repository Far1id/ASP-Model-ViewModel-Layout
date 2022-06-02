using ASP_Database_connection.Models;
using ASP_Database_connection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Database_connection.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
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

            ServiceViewModel serviceViewModel = new ServiceViewModel
            {
                Services = services
            };
            return View(serviceViewModel);
        }

        public IActionResult Detail(int id)
        {
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

            Service service = services.Find(x => x.Id == id);
            return View(service);
        }
    }
}
