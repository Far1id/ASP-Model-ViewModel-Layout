using ASP_Database_connection.Models;
using System.Collections.Generic;

namespace ASP_Database_connection.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
    }
}
