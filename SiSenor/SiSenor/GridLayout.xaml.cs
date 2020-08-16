using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SiSenor.Views.Description;

namespace SiSenor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayout : ContentPage
    {
        public GridLayout()
        {
            InitializeComponent();
            ComidaSeccion_btn_Tacos.Clicked += ComidaSeccion_btn_Tacos_Clicked;
        }

        private void ComidaSeccion_btn_Tacos_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new PlantillaDescripcion());
        }
    }
}