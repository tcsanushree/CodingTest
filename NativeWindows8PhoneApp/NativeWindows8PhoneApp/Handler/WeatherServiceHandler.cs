using NativeWindows8PhoneApp.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NativeWindows8PhoneApp.Handler
{
    public class WeatherServiceHandler
    {
        private string WEATHER_API_MSG = "https://api.forecast.io/forecast/7cf705abd2b841b2d9f9ebd8d3f732d1/{0},{1}";  

        public async Task<WeatherResponse> GetWeatherData(string latitude, string longitude)
        {
            string url = string.Format(WEATHER_API_MSG, latitude, longitude);  
            return await GetWeather(url);
        }

        public async Task<WeatherResponse> GetWeather(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    client.BaseAddress = new Uri(url);

                    HttpResponseMessage response = await client.GetAsync(url);
                    var newdata = response.Content.ReadAsStringAsync();
                    WeatherResponse objweatherResponse = NativeWindows8PhoneApp.Utilities.JsonSerializer.Deserialize<WeatherResponse>(newdata.Result);
                    return objweatherResponse;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
