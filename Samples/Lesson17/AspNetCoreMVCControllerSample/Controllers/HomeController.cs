using AspNetCoreMVCControllerSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreMVCControllerSample.Controllers
{
    [Controller]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromQuery]int id)
        {
            ViewData["ViewDataId"] = id;
            ViewBag.Id = id;
            TempData["TempDataId"] = id;
            return View(id);
        }

        [HttpPost]
        public IActionResult Save(string firstName)
        {
            var id = ViewData["ViewDataId"];
            var viewBagId = ViewBag.Id;
            var tempDataId = TempData["TempDataId"];
            TempData["TempDataId"] = tempDataId ?? default;
            return RedirectToAction("Hello", "Home", new {firstName = firstName});
        }

        [HttpGet]
        public string Hello(string firstName)
        {
            var id = ViewData["ViewDataId"];
            var viewBagId = ViewBag.Id;
            var tempDataId = TempData["TempDataId"];
            return $"Hello {firstName} {id}!";
        }

        [HttpGet]
        [ActionName("Wellcome")]
        public string HelloId(int id, string name)
        {
            return $"Hello {id} {name}!";
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
