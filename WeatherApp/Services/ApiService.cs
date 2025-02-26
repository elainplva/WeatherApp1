using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longitude}&appid=faeb14dd3f0d880980cf2137b29720e6");

            return JsonConvert.DeserializeObject<Root>(response) ?? new Root();  // Ensure it's never null
        }

        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid=faeb14dd3f0d880980cf2137b29720e6");

            return JsonConvert.DeserializeObject<Root>(response) ?? new Root();
        }

    }
}
