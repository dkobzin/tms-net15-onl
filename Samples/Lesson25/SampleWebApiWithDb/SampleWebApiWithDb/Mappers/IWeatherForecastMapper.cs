using DataAccessLayer.Entities;
using SampleWebApiWithDb.Models;

namespace SampleWebApiWithDb.Mappers;

public interface IWeatherForecastMapper
{
    WeatherForecast MapToModel(WeatherForecastEntity entity);
}