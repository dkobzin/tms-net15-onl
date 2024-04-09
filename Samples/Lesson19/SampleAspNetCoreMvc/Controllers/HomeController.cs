using Microsoft.AspNetCore.Mvc;
using SampleAspNetCoreMvc.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace SampleAspNetCoreMvc.Controllers
{
    //[Authorize]
    [SimpleActionFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        [SimpleActionFilter]
        public IActionResult Index()
        {
            return View();
        }

        [CustomActionResourceFilter("F6FF73E5-56FC-4B20-B81E-9D80CDDA2238", nameof(Privacy))]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [ExceptionFilter]
        [ActionName("ThrowException")]
        public IActionResult ThrowException()
        {
            throw new ArgumentException($"{nameof(ArgumentException)}");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
