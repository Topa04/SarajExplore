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
    public partial class Food : ContentPage
    {
        public Food()
        {
            InitializeComponent();
        }

        private async void restaurantsMore(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Restaurants());
        }
        private async void cevapMore(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cevabdzinica());
        }
        private async void pastryMore(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PastryShop());
        }
    }
}