using BlazorSharedModel.Shared;
using System.Net.Http.Json;

namespace BlazorSharedModel.Client.Services;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly HttpClient http;

    public WeatherForecastService(HttpClient http)
    {
        this.http = http;
    }

    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await http.GetFromJsonAsync<IEnumerable<WeatherForecast>>("WeatherForecast") ?? Array.Empty<WeatherForecast>();
    }
}
