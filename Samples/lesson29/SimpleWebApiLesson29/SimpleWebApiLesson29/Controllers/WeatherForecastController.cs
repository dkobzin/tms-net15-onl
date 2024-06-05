using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApiLesson29.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Weather Forecast
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetWeatherForecast")]
        [ProducesResponseType(typeof(IEnumerable<WeatherForecast>), 201)]
        [ProducesResponseType(typeof(IEnumerable<WeatherForecast>), 400)]

        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// GetWeatherForecast
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{name:alpha}")]
        [ProducesResponseType(typeof(WeatherForecast), 201)]
        [ProducesResponseType(typeof(ArgumentNullException), 400)]
        //public WeatherForecast GetWeatherForecast([Required]string name)
        public WeatherForecast GetWeatherForecast(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

            var summary = Summaries.SingleOrDefault(p => p.Equals(name));
            return new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Today),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summary
            };
        }

        // Please look for examples
        /*[HttpGet]
        public IActionResult GetAll()
        {
            if (!false) return BadRequest();
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
            return Ok(result);
        }*/
    }
}
