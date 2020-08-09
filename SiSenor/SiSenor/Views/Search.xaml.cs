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
    public partial class Search : ContentPage
    {
        List<string> list = new List<string>
        {
            "Red", "Blue", "Green", "Magenta", "Yellow", "Orange"
        };

        public Search()
        {
            InitializeComponent();
        }

        private void Search_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = Buscar.Text;
            var suggestion = list.Where(c => c.ToLower().Contains(keyword.ToLower()));

            Empresas.ItemsSource = suggestion;
        }
    }
}