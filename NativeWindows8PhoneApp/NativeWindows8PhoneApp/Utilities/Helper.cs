using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeWindows8PhoneApp.Utilities
{
    public static class Helper
    {
        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }

        public static string GetImageURL(string icon)
        {
            switch (icon)
            {
                case "rain":
                    return "Assets/rain.jpg";                
                case "sunny":
                    return "Assets/sunny.jpg";
                case "clear-day":
                    return "Assets/sunny.jpg";
                case "clear-night":
                    return "Assets/cloudy.jpg";
                case "partly-cloudy-day":
                    return "Assets/partly cloudy.jpg";
                case "fog":
                    return "Assets/fog.jpg";
                case "snow":
                    return "Assets/snow.jpg";
                default:
                    return "Assets/partly cloudy.jpg";
            }
        }
    }
}
