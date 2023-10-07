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
	public partial class Cevabdzinica : ContentPage
	{
		public Cevabdzinica ()
		{
			InitializeComponent ();
		}
        private async void openMore(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 10:
                    await Launcher.OpenAsync(new Uri("https://ferhatovic.ba/o-nama"));
                    break;
                case 11:
                    await Launcher.OpenAsync(new Uri("https://www.indeks.ba/preduzece/%c4%86EVABD%c5%bdINICA_%c5%bdELJO.html"));
                    break;
                case 12:
                    await Launcher.OpenAsync(new Uri("http://www.cevabdzinicazmaj.ba/ba/"));
                    break;
                case 13:
                    await Launcher.OpenAsync(new Uri("https://nune.ba/"));
                    break;
            }
        }
        private async void openMenu(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 20:
                    await Launcher.OpenAsync(new Uri("https://ferhatovic.ba/meni"));
                    break;
                case 21:
                    await Launcher.OpenAsync(new Uri("https://korpa.ba/partner/cevabdzinica-zeljo-1"));
                    break;
                case 22:
                    await Launcher.OpenAsync(new Uri("http://www.cevabdzinicazmaj.ba/ba/#meni"));
                    break;
                case 23:
                    await Launcher.OpenAsync(new Uri("https://nune.ba/meni/"));
                    break;
            }
        }
        private async void openMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 30:
                    await Map.OpenAsync(43.85901230034345, 18.432231725515177);
                    break;
                case 31:
                    await Map.OpenAsync(43.85866542190982, 18.429974159142784);
                    break;
                case 32:
                    await Map.OpenAsync(43.84921256805824, 18.378004911536056);
                    break;
                case 33:
                    await Map.OpenAsync(43.85851514560264, 18.42328088748306);
                    break;
            }
        }
    }
}