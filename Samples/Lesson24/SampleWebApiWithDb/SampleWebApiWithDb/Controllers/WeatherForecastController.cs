using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using SampleWebApiWithDb.Mappers;
using SampleWebApiWithDb.Models;

namespace SampleWebApiWithDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastMapper _weatherForecastMapper;
        private readonly ApplicationDbContext _applicationDbContext;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastMapper weatherForecastMapper, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _weatherForecastMapper = weatherForecastMapper;
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            /*return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();*/
            var weatherForecasts = _applicationDbContext.WeatherForecastEntities
                .Skip(0)
                .Take(10)
                .ToList();

            return weatherForecasts
                .Select(weatherForecastEntity => _weatherForecastMapper.MapToModel(weatherForecastEntity))
                .ToList();
        }
    }
}
