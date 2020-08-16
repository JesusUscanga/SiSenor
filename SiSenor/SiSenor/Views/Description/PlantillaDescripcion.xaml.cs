using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiSenor.Views.Description
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantillaDescripcion : ContentPage
    {
        public PlantillaDescripcion()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (await Launcher.CanOpenAsync("https://api.whatsapp.com/send?phone=522291079295"))
            {
                await Launcher.OpenAsync("https://api.whatsapp.com/send?phone=522291079295");
            }
        }
    }
}