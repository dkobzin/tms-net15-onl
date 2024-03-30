using HomeTask15Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
namespace HomeTask15Web.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly ISettings _settings;
        public HomeController(ISettings settings,ILogger<HomeController> logger)
        {
            _logger = logger;
            _settings = settings;
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
            
           _settings.GetMeSettings();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
