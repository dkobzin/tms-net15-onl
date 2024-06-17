using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities;

//[Table("WeatherForecasts")]
public class WeatherForecastEntity
{
    [Key]
    public Guid Id { get; set; }
    //[Column("WeatherDate")]
    //[Required]
    public DateOnly Date { get; set; }

    //[Column("TemperatureC")]
    public int TemperatureC { get; set; }

    //[Column("Summary")]
    public string? Summary { get; set; }
}