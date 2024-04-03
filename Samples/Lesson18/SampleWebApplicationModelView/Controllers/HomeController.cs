using Microsoft.AspNetCore.Mvc;
using SampleWebApplicationModelView.Models;
using System.Diagnostics;
using Services;
using Services.DTO;

namespace SampleWebApplicationModelView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly PersonService personService;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            personService = new PersonService();
        }

        public IActionResult Index()
        {
            var personViewModel = GetPersonViewModel(Guid.NewGuid());
            return View(personViewModel);
        }

        private PersonViewModel GetPersonViewModel(Guid id)
        {
            var person = personService.GetPerson(id);
            var personViewModel = new PersonViewModel
            {
                Id = person.Id,
                Name = person.Name
            };
            return personViewModel;
        }

        [HttpGet]
        public IActionResult Get([FromQuery]Guid id)
        {
            var model = GetPersonViewModel(id);
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PersonViewModel model)
        {
            var personDto = new PersonDto
            {
                Id = model.Id,
                Name = model.Name
            };
            personService.SavePerson(personDto);
            return Ok(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login([FromForm] LoginViewModel model)
        {
            var authData = $"Login: {model.Login}   Password: {model.Password}";
            return Content(authData);
            //return RedirectToAction();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
