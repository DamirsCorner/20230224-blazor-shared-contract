namespace BlazorSharedModel.Shared;
public interface IWeatherForecastService
{
    Task<IEnumerable<WeatherForecast>> Get();
}
