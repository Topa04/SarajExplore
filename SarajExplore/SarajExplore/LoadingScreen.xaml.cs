using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SarajExplore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingScreen : ContentPage
    {
        public LoadingScreen()
        {
            InitializeComponent();
            Timer();
        }

        public async void Timer()
        {
            await Task.Delay(2000);
            newPage();
        }
        public async void newPage()
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}