using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NativeWindows8PhoneApp.Models.Responses
{
    // deleted the old class structure.. created new one.... 

    [DataContract]
    public class WeatherResponse
    {
        [DataMember(Name = "latitude")]
        public double Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }

        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }

        [DataMember(Name = "offset")]
        public double Offset { get; set; }

        [DataMember(Name = "currently")]
        public Currently Currently { get; set; }

        [DataMember(Name = "hourly")]
        public Hourly Hourly { get; set; }

        [DataMember(Name = "daily")]
        public Daily Daily { get; set; }

        [DataMember(Name = "flags")]
        public Flags Flags { get; set; }
    }

    [DataContract]
   public class Currently
    {
        [DataMember(Name = "time")]
        public int Time { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "precipIntensity")]
        public double PrecipIntensity { get; set; }

        [DataMember(Name = "precipProbability")]
        public double PrecipProbability { get; set; }

        [DataMember(Name = "precipType")]
        public string PrecipType { get; set; }

        [DataMember(Name = "temperature")]
        public double Temperature { get; set; }

        [DataMember(Name = "apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [DataMember(Name = "dewPoint")]
        public double DewPoint { get; set; }

        [DataMember(Name = "humidity")]
        public double Humidity { get; set; }

        [DataMember(Name = "windSpeed")]
        public double WindSpeed { get; set; }

        [DataMember(Name = "windBearing")]
        public int WindBearing { get; set; }

        [DataMember(Name = "cloudCover")]
        public double CloudCover { get; set; }

        [DataMember(Name = "pressure")]
        public double Pressure { get; set; }

        [DataMember(Name = "ozone")]
        public double Ozone { get; set; }

        public string PictureUrl { get; set; }

        public DateTime TimeStamp { get; set; }
    }

    [DataContract]
    public class Hourly
    {
         [DataMember(Name = "summary")]
         public string Summary { get; set; }

         [DataMember(Name = "icon")]
        public string Icon { get; set; }

         [DataMember(Name = "data")]
         public List<HourlyData> Data { get; set; }
    }

    [DataContract]
    public class Daily
    {
        [DataMember(Name = "summary")]
        public string summary { get; set; }

        [DataMember(Name = "icon")]
        public string icon { get; set; }

        [DataMember(Name = "data")]
        public List<DailyData> data { get; set; }
    }

    [DataContract]
    public class HourlyData
    {
        [DataMember(Name = "time")]
        public int Time { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "precipIntensity")]
        public double PrecipIntensity { get; set; }

        [DataMember(Name = "precipProbability")]
        public double PrecipProbability { get; set; }

        [DataMember(Name = "precipType")]
        public string PrecipType { get; set; }

        [DataMember(Name = "temperature")]
        public double Temperature { get; set; }

        [DataMember(Name = "apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [DataMember(Name = "dewPoint")]
        public double DewPoint { get; set; }

        [DataMember(Name = "humidity")]
        public double Humidity { get; set; }

        [DataMember(Name = "windSpeed")]
        public double WindSpeed { get; set; }

        [DataMember(Name = "windBearing")]
        public int WindBearing { get; set; }

        [DataMember(Name = "cloudCover")]
        public double CloudCover { get; set; }

        [DataMember(Name = "pressure")]
        public double Pressure { get; set; }

        [DataMember(Name = "ozone")]
        public double Ozone { get; set; }

        public string PictureUrl { get; set; }

        public DateTime TimeStamp { get; set; }
    }

    [DataContract]
    public class DailyData
    {
        [DataMember(Name = "time")]
        public int Time { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "sunriseTime")]
        public int SunriseTime { get; set; }

        [DataMember(Name = "sunsetTime")]
        public int SunsetTime { get; set; }

        [DataMember(Name = "moonPhase")]
        public double MoonPhase { get; set; }

        [DataMember(Name = "precipIntensity")]
        public double PrecipIntensity { get; set; }

        [DataMember(Name = "precipIntensityMax")]
        public double PrecipIntensityMax { get; set; }

        [DataMember(Name = "precipIntensityMaxTime")]
        public int PrecipIntensityMaxTime { get; set; }

        [DataMember(Name = "precipProbability")]
        public double PrecipProbability { get; set; }

        [DataMember(Name = "precipType")]
        public string PrecipType { get; set; }

        [DataMember(Name = "temperatureMin")]
        public double TemperatureMin { get; set; }

        [DataMember(Name = "temperatureMinTime")]
        public int TemperatureMinTime { get; set; }

        [DataMember(Name = "temperatureMax")]
        public double TemperatureMax { get; set; }

        [DataMember(Name = "temperatureMaxTime")]
        public int TemperatureMaxTime { get; set; }

        [DataMember(Name = "apparentTemperatureMin")]
        public double ApparentTemperatureMin { get; set; }

        [DataMember(Name = "apparentTemperatureMinTime")]
        public int ApparentTemperatureMinTime { get; set; }

        [DataMember(Name = "apparentTemperatureMax")]
        public double ApparentTemperatureMax { get; set; }

        [DataMember(Name = "apparentTemperatureMaxTime")]
        public int ApparentTemperatureMaxTime { get; set; }

        [DataMember(Name = "dewPoint")]
        public double DewPoint { get; set; }

        [DataMember(Name = "humidity")]
        public double Humidity { get; set; }

        [DataMember(Name = "windSpeed")]
        public double WindSpeed { get; set; }

        [DataMember(Name = "windBearing")]
        public int WindBearing { get; set; }

        [DataMember(Name = "cloudCover")]
        public double CloudCover { get; set; }

        [DataMember(Name = "pressure")]
        public double Pressure { get; set; }

        [DataMember(Name = "ozone")]
        public double Ozone { get; set; }

        public string PictureUrl { get; set; }

        public DateTime TimeStamp { get; set; }
    }

    [DataContract]
    public class Flags
    {
        [DataMember(Name = "sources")]
        public List<string> Sources { get; set; }

        [DataMember(Name = "isd-stations")]
        public List<string> Isdstations { get; set; }

        [DataMember(Name = "units")]
        public string Units { get; set; }
    }


}

