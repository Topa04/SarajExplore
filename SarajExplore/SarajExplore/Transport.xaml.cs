using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SarajExplore
{
    public partial class Transport : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Transport()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private void linija(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            Navigation.ShowPopup(new TransportPopup(dugme.TabIndex));
        }

        private void transportMountains(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TransportM());
        }
        private void transportTrain(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new TransportPopup(4));
        }
        private void rentCar(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new RentCarPopup());
        }
        private void emergencyNumbers(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new emNumbers());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://play.google.com/store/apps/details?id=com.kentkart.centrotransbus");
        }
    }
}