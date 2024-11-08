using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WeatherForecastApp.Models;

namespace WeatherForecastApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public WeatherService(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _apiKey = configuration["OpenWeatherMap:ApiKey"];
        }

        public async Task<WeatherModel> GetWeatherAsync(string city)
        {
            var response = await _httpClient.GetStringAsync(
                $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric");
            return JsonConvert.DeserializeObject<WeatherModel>(response);
        }
    }
}
