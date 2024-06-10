using System.ComponentModel.DataAnnotations;

namespace SimpleWebApiLesson29
{
    public class WeatherForecast
    {

        [Display(Description = "Date Weather")]
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required]
        public string? Summary { get; set; }
    }
}
