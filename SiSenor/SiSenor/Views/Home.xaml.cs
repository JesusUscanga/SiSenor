using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiSenor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            Home_Btn_Comida.Clicked += Home_Btn_Comida_Clicked;
            ComidaSeccion_btn_Tacos.Clicked += ComidaSeccion_btn_Tacos_Clicked;
        }

        private void Home_Btn_Comida_Clicked(object sender, EventArgs e)
        {

            //Navigation.PushAsync(new GridLayout());
            Tipos.IsVisible = true;
            Secciones.IsVisible = false; 
        }

        private void ComidaSeccion_btn_Tacos_Clicked(object sender, EventArgs e)
        {
            Tipos.IsVisible = false;
            Secciones.IsVisible = false;
            Descripcion.IsVisible = true;
        }

        async void Whats_Clicked(object sender, EventArgs e)
        {
            if (await Launcher.CanOpenAsync("https://api.whatsapp.com/send?phone=522291079295"))
            {
                await Launcher.OpenAsync("https://api.whatsapp.com/send?phone=522291079295");
            }
        }
    }
}