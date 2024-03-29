using HomeTask15Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeTask15Web.Controllers
{
    public class HomeController : Controller
    {
        private  SettingsService settings;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult MeetingRoom()
        {
            settings = HttpContext.RequestServices.GetService<SettingsService>() ?? new SettingsService();
            settings.GetMeSettings(new Person() { Name = "Vasa", LastName ="Petrov", UserIsSharing=true});
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
