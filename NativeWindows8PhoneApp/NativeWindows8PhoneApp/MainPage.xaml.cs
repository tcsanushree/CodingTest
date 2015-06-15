using NativeWindows8PhoneApp.BLFacade;
using NativeWindows8PhoneApp.Models.Responses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;
using NativeWindows8PhoneApp.Utilities;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace NativeWindows8PhoneApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {   
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Get the current Location
            GetLocation();            
        }

        async private void GetLocation()
        {
            try
            {
                var geolocator = new Geolocator();

                Geoposition position = await geolocator.GetGeopositionAsync();
                Geocoordinate coordinate = position.Coordinate;

                //LatitudeText.Text = coordinate.Latitude.ToString();
                //LongitudeText.Text = coordinate.Longitude.ToString();

                LocationFacade.Instance.SetCoOrdinates(coordinate.Latitude.ToString(), coordinate.Longitude.ToString());
                //Use the co-ordinates to fetch the weather forecast
                WeatherResponse response = await WeatherFacade.Instance.GetWeatherData(coordinate.Latitude.ToString(), coordinate.Longitude.ToString());
                BindData(response);
                myProgressRing.IsActive = false;
            }
            catch(Exception ex)
            {
                //If there is exception in fetching co-ordinates                
                //LatitudeText.Text = "";
                //LongitudeText.Text = "";
                myProgressRing.IsActive = false;
            }
        }

        private void BindData(WeatherResponse response)
        {
            myProgressRing.IsActive = true;

            //For current binding
            Currently current = new Currently();
            current = response.Currently;
            current.PictureUrl = Helper.GetImageURL(current.Icon);
            current.TimeStamp = Helper.ConvertFromUnixTimestamp(current.Time);
            List<Currently> currentList = new List<Currently>();
            currentList.Add(current);
            lstboxCurrent.ItemsSource = currentList;

            //For daily binding
            try
            {
                Daily daily = new Daily();
                daily = response.Daily;
                List<DailyData> data = daily.data;
                for (int i = 0; i < data.Count; i++)
                {
                    data[i].PictureUrl = Helper.GetImageURL(data[i].Icon);
                    data[i].TimeStamp = Helper.ConvertFromUnixTimestamp(data[i].Time);
                }
                lstboxDaily.ItemsSource = data;
            }
            catch
            {
                //do nothing
            }

            //For hourly binding
            try
            {
                Hourly hourly = new Hourly();
                hourly = response.Hourly;
                List<HourlyData> hourlydata = hourly.Data;
                for (int i = 0; i < hourlydata.Count; i++)
                {
                    hourlydata[i].PictureUrl = Helper.GetImageURL(hourlydata[i].Icon);
                    hourlydata[i].TimeStamp = Helper.ConvertFromUnixTimestamp(hourlydata[i].Time);
                }
                lstboxHourly.ItemsSource = hourlydata;
            }
            catch
            {
                // do nothing
            }

            myProgressRing.IsActive = false;
        }        
    }
}
