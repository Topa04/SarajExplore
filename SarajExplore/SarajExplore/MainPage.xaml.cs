using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SarajExplore
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RemoveLoadingScreenFromStackAsync();
        }

        private void TourGuidePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new tourGuide());
        }
        private void TransportPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Transport());
        }
        private void FoodPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Food());
        }
        private void HotelPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hotel());
        }
        private async void ExchangePage(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://www.google.com/maps/search/exchange/@43.8537768,18.3193737,13z/data=!3m1!4b1?entry=ttu"));
        }
        private void SarajevoGuidePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SarajevoGuide());
        }
        private async void RemoveLoadingScreenFromStackAsync()
        {
            await Task.Delay(100);
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
    }
}
