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
	public partial class Tour1Day1 : ContentPage
	{   
		public Tour1Day1 ()
		{
			InitializeComponent ();
            scrollView.Scrolled += (sender, e) =>
            {
                var scrollY = e.ScrollY; // Vertical scroll position
                if (scrollY > 100)
                {
                    krug1.Color = Color.FromHex("#b3b3b3");
                }
                else if (scrollY < 100)
                {
                    krug1.Color = Color.Black;
                }
                if (scrollY > 400)
                {
                    krug2.Color = Color.FromHex("#b3b3b3");
                }
                else if (scrollY < 400)
                {
                    krug2.Color = Color.Black;
                }
                if (scrollY > 650)
                {
                    krug3.Color = Color.FromHex("#b3b3b3");
                }
                else if (scrollY < 650)
                {
                    krug3.Color = Color.Black;
                }
                if (scrollY > 875)
                {
                    krug4.Color = Color.FromHex("#b3b3b3");
                }
                else if (scrollY < 875)
                {
                    krug4.Color = Color.Black;
                }
                if (scrollY > 1190)
                {
                    krug5.Color = Color.FromHex("#b3b3b3");
                }
                else if (scrollY < 1190)
                {
                    krug5.Color = Color.Black;
                }
                if (scrollY > 1330)
                {
                    krug6.Color = Color.FromHex("#b3b3b3");
                    krug7.Color = Color.FromHex("#b3b3b3");
                    krug8.Color = Color.FromHex("#b3b3b3");
                }
                else if (scrollY < 1330)
                {
                    krug6.Color = Color.Black;
                    krug7.Color = Color.Black;
                    krug8.Color = Color.Black;
                }
            };
        }

        private void houseOfSpite(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StubbornHouse());
        }
        private void cityHall(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Vijecnica());
        }
        private void bascarsija(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bascarsija());
        }
        private void sebilj(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sebilj());
        }

        private async void openMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 0:
                    await Map.OpenAsync(43.858954, 18.433807);
                    break;
                case 1:
                    await Map.OpenAsync(43.859056, 18.431015);
                    break;
                case 2:
                    await Map.OpenAsync(43.859473, 18.431121);
                    break;
            }
        }
    }
}