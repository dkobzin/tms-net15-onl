using DataAccessLayer.Entities;
using SampleWebApiWithDb.Models;

namespace SampleWebApiWithDb.Mappers;

public class WeatherForecastMapper : IWeatherForecastMapper
{
    public WeatherForecast MapToModel(WeatherForecastEntity entity)
    {
        return new WeatherForecast
        {
            Id = entity.Id,
            Date = entity.Date,
            Summary = entity.Summary,
            TemperatureC = entity.TemperatureC
        };
    }
}