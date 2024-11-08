using Newtonsoft.Json;

namespace WeatherForecastApp.Models
{
    public class WeatherModel
    {
        [JsonProperty("name")]
        public string City { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("weather")]
        public List<WeatherDescription> Weather { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }

    public class WeatherDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
