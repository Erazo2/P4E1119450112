using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Geolocator;
using  GoogleMaps;


namespace P4E1119450112.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMaps : ContentPage
    {
        private object mapas;

        public PageMaps()
        {
            InitializeComponent();
        }
        protected  async override void OnAppearing()
        {
            base.OnAppearing();

            var localizacion = CrossGeolocator.Current;
            if (localizacion != null)
            {
                if (!localizacion.IsListening)
                {
                    await localizacion.StartListeningAsync(TimeSpan.FromSeconds(10), 100);
                }

                var posicion = await localizacion.GetPositionAsync();
                var centromap = new Xamarin.Forms.Maps.Position(posicion.Latitude, posicion.Longitude);
                mapas.MoveToRegion(new MapSpan(centromap, 1, 1));
            }

            
        }
    }

}