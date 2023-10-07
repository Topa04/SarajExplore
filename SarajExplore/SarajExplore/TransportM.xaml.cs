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
	public partial class TransportM : ContentPage
	{
		public TransportM ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
			var dugme = sender as Button;
			if(dugme.TabIndex==1)
			{
                await Map.OpenAsync(43.8595701399384, 18.433394999832633);
            }
            else if (dugme.TabIndex == 2)
            {
                await Map.OpenAsync(43.823635053564374, 18.356687188492966);
            }
            else if(dugme.TabIndex == 3)
            {
                await Map.OpenAsync(43.855519225343606, 18.434943833761977);
            }
            else if(dugme.TabIndex == 4)
            {
                await Launcher.OpenAsync(new Uri("https://www.zicara.ba/"));
            }
        }
    }
}