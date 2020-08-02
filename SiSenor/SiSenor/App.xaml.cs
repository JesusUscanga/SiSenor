using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiSenor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Tabbed();


        }

        protected override void OnStart()
        {
            
            //MainPage = new Maps();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
