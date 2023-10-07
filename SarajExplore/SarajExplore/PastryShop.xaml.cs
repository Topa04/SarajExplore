using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SarajExplore
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PastryShop : ContentPage
	{
		public PastryShop ()
		{
			InitializeComponent ();
		}
        private async void openMore(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 10:
                    await Launcher.OpenAsync(new Uri("https://biz4b.com/listing-item/slasticarski-proizvodi/"));
                    break;
                case 11:
                    await Launcher.OpenAsync(new Uri("https://bascarsija.ba/slasticarne/ramis"));
                    break;
                case 12:
                    await Launcher.OpenAsync(new Uri("https://bascarsija.ba/slasticarne/cream-shop"));
                    break;
                case 13:
                    await Launcher.OpenAsync(new Uri("https://baklava.ba/"));
                    break;
                case 14:
                    await Launcher.OpenAsync(new Uri("https://bascarsija.ba/slasticarne/caffe-slasticarna-carigrad-s-u-r"));
                    break;
                case 15:
                    await Launcher.OpenAsync(new Uri("https://restaurantguru.com/Slasticarna-Ramis-Sarajevo"));
                    break;
                case 16:
                    await Launcher.OpenAsync(new Uri("https://ladelicia.ba/"));
                    break;
                case 17:
                    await Launcher.OpenAsync(new Uri("https://mrvica.ba/"));
                    break;
            }
        }
        private async void openMenu(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 20:
                    await Launcher.OpenAsync(new Uri("https://www.facebook.com/slasticarnasaraj"));
                    break;
                case 21:
                    await Launcher.OpenAsync(new Uri("https://korpa.ba/partner/slasticarna-ramis"));
                    break;
                case 22:
                    await Launcher.OpenAsync(new Uri("https://glovoapp.com/ba/hr/sarajevo/cream-shop-srv/"));
                    break;
                case 23:
                    await Launcher.OpenAsync(new Uri("https://baklava.ba/naruci-baklave/"));
                    break;
                case 24:
                    await Launcher.OpenAsync(new Uri("https://sarajevo.travel/ba/sta-raditi/carigrad/965"));
                    break;
                case 25:
                    await Launcher.OpenAsync(new Uri("https://restaurantguru.com/Slasticarna-Ramis-Sarajevo/menu"));
                    break;
                case 26:
                    await Launcher.OpenAsync(new Uri("https://qrmenu.podrska.ba/menu/41"));
                    break;
                case 27:
                    await Launcher.OpenAsync(new Uri("https://mrvica.ba/"));
                    break;
            }
        }
        private async void openMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 30:
                    await Map.OpenAsync(43.85981853879361, 18.43164969454777);
                    break;
                case 31:
                    await Map.OpenAsync(43.859379423701036, 18.4282714799601);
                    break;
                case 32:
                    await Map.OpenAsync(43.859118168712264, 18.43075812988933);
                    break;
                case 33:
                    await Map.OpenAsync(43.85897720339705, 18.431324371545475);
                    break;
                case 34:
                    await Map.OpenAsync(43.85936347960675, 18.43079953873615);
                    break;
                case 35:
                    await Map.OpenAsync(43.85938872113932, 18.427902783355165);
                    break;
                case 36:
                    await Map.OpenAsync(43.87324719149672, 18.412332071501805);
                    break;
                case 37:
                    await Map.OpenAsync(43.85928112762482, 18.426224555913326);
                    break;
            }
        }
    }
}