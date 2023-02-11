using BlazorSharedModel.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSharedModel.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService weatherForecastService;

    public WeatherForecastController(IWeatherForecastService weatherForecastService)
    {
        this.weatherForecastService = weatherForecastService;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await this.weatherForecastService.Get();
    }
}
