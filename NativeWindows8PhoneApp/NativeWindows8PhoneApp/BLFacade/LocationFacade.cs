using NativeWindows8PhoneApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace NativeWindows8PhoneApp.BLFacade
{
    public class LocationFacade
    {
        #region Singleton Implementation
        private LocationFacade()
        {
        }

        public static LocationFacade Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly LocationFacade instance = new LocationFacade();
        }
        #endregion

        public static string Latitude;
        public static string Longitude;

        #region Service calls
        public void SetCoOrdinates(string lat, string lon)
        {
            try
            {
                Latitude = lat;
                Longitude = lon;
            }
            catch
            {
                
            }
        }
        #endregion
    }
}
