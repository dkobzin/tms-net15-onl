using hw16.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using hw16.Models;
using hw16.Services;

namespace hw16.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetRoomSettings _settingsService;

        public HomeController(ILogger<HomeController> logger, IGetRoomSettings settings)
        {
            _settingsService = settings ?? throw new ArgumentNullException(nameof(settings));
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

        public IActionResult MyTest()
        {
            var settings = _settingsService.GetSettings();
            return View(settings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
