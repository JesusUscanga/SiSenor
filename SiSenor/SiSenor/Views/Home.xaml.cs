using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void Home_Btn_Comida_Clicked(object sender, EventArgs e)
        {
            //((NavigationPage)this.Parent).PushAsync(new Maps());
            Navigation.PushAsync(new GridLayout());
        }
    }
}