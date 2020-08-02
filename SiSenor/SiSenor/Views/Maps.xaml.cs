using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiSenor.Class;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.GoogleMaps;

namespace SiSenor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maps : ContentPage
    {
        public GeoLocation _GeoLocation = new GeoLocation();
        public Maps()
        {
            InitializeComponent();
            ConfigMap();
            moveToActualPosition();
        }

        void ConfigMap()
        {
            mapa.UiSettings.CompassEnabled = true;
            mapa.UiSettings.MyLocationButtonEnabled = true;
            mapa.UiSettings.MapToolbarEnabled = true;
            mapa.MyLocationEnabled = true;
            mapa.FlowDirection = FlowDirection.LeftToRight;
            mapa.MapType = MapType.Street;

        }

        void moveToActualPosition()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await _GeoLocation.getLocationGPS();
                Position _position = new Position(GeoLocation.lat, GeoLocation.lng);
                mapa.MoveToRegion(MapSpan.FromCenterAndRadius(_position, Distance.FromMeters(500)), true);
                Distancia.Text = GeoLocation.distance.ToString();

                var defaultPin = new Pin { Type = PinType.Place, Label = "Aqui Estas", Address = "Aqui", Position = new Position(GeoLocation.lat, GeoLocation.lng) };
                mapa.Pins.Add(defaultPin);

            });

        }
    }
}