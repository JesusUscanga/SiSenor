using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SiSenor.Class
{
    public class GeoLocation
    {
        public static double lat { get; set; }

        public static double lng { get; set; }

        public static double distance { get; set; }

        public async Task getLocationGPS()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    lat = location.Latitude;
                    lng = location.Longitude;

                    Location actualPosition = new Location(lat, lng);
                    Location negocio = new Location(19.154789, -96.123249);
                    distance = Location.CalculateDistance(actualPosition, negocio, DistanceUnits.Kilometers);
                    //Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
                else
                {
                    var knowLocation = await Geolocation.GetLastKnownLocationAsync();
                    lat = knowLocation.Latitude;
                    lng = knowLocation.Longitude;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }


        }

        public void Distance()
        {
            Location actualPosition = new Location(lat, lng);
            Location negocio = new Location(19.193932, -96.167612);
            distance = Location.CalculateDistance(actualPosition, negocio, DistanceUnits.Kilometers);
        }
    }
}
