using System.Net.Http.Json;
using SimpleClient;

var client = new HttpClient();
var response = await client.GetAsync("http://localhost:5176/weatherforecast");

Console.WriteLine(response.StatusCode);

if (response.IsSuccessStatusCode)
{
    var weatherForecasts = await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecast>>();
    foreach (var weatherForecast in weatherForecasts)
    {
        Console.WriteLine($"Weather forecast: {weatherForecast.Date} {weatherForecast.TemperatureC}C {weatherForecast.TemperatureF}F {weatherForecast.Summary}");
    }
}

Console.ReadLine();