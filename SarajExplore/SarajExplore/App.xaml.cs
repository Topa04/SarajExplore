using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:ExportFont("Montserrat-Regular.ttf", Alias ="Mont")]
namespace SarajExplore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoadingScreen());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
