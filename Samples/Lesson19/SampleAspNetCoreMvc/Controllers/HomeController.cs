using Microsoft.AspNetCore.Mvc;
using SampleAspNetCoreMvc.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using SampleAspNetCoreMvc.Services;

namespace SampleAspNetCoreMvc.Controllers
{
    //[Authorize]
    [SimpleActionFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        
        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [AllowAnonymous]
        [SimpleActionFilter]
        [HttpGet]
        public IActionResult Index()
        {
            var user = _userService.GetById(1);
            return View("Index", user);
        }

        [HttpPost]
        public IActionResult User([FromForm] UserModel user)
        {
            _userService.Save(user);
            return RedirectToAction("Index");
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
