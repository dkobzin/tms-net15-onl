using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            IWeatherForecastMapper weatherForecastMapper, 
            ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _weatherForecastMapper = weatherForecastMapper;
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var weatherForecasts = _applicationDbContext.WeatherForecastEntities
                .AsNoTracking() // NoTracking
                .AsTracking() // Tracking
                .Skip(0)
                .Take(10)
                .ToList();

            return weatherForecasts
                .Select(weatherForecastEntity => _weatherForecastMapper.MapToModel(weatherForecastEntity))
                .ToList();
        }
    }
}
