using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class City
    {
        public int id { get; set; }
        public string? name { get; set; }  // Nullable to avoid warnings
        public Coord coord { get; set; } = new Coord(); // Initialized
        public string? country { get; set; }
        public int population { get; set; }
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class WeatherData
    {
        public int dt { get; set; }
        public Main main { get; set; } = new Main();  // Initialized
        public List<Weather> weather { get; set; } = new List<Weather>(); // Initialized
        public Clouds clouds { get; set; } = new Clouds(); // Initialized
        public Wind wind { get; set; } = new Wind(); // Initialized
        public int visibility { get; set; }
        public double pop { get; set; }
        public Sys sys { get; set; } = new Sys(); // Initialized
        public string dt_txt { get; set; } = ""; // Default empty string
        public Snow? snow { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }
    }

    public class Root
    {
        public string cod { get; set; } = ""; // Default empty string
        public int message { get; set; }
        public int cnt { get; set; }

        [JsonProperty("list")]
        public List<WeatherData> WeatherList { get; set; } = new List<WeatherData>(); // Initialized

        public City city { get; set; } = new City(); // Initialized
    }

    public class Snow
    {
        [JsonProperty("3h")]
        public double _3h { get; set; }
    }

    public class Sys
    {
        public string pod { get; set; } = ""; // Default empty string
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; } = ""; // Default empty string
        public string description { get; set; } = ""; // Default empty string
        public string icon { get; set; } = ""; // Default empty string
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }
}




