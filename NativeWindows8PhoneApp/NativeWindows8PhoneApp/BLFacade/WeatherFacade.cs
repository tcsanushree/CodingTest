using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeWindows8PhoneApp.Handler;
using NativeWindows8PhoneApp.Models.Responses;
using Windows.Devices.Geolocation;

namespace NativeWindows8PhoneApp.BLFacade
{
    public class WeatherFacade
    {
        #region Singleton Implementation
        private WeatherFacade()
        {
        }

        public static WeatherFacade Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly WeatherFacade instance = new WeatherFacade();
        }
        #endregion

        #region Service calls
        public async Task<WeatherResponse> GetWeatherData(string latitude, string longitude)
        {
            try
            {
                if (!String.IsNullOrEmpty(latitude))
                {
                    WeatherServiceHandler weatherservicehandler = new WeatherServiceHandler();
                    WeatherResponse res = await weatherservicehandler.GetWeatherData(latitude, longitude);
                    return res;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
