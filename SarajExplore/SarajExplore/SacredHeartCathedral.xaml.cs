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
	public partial class SacredHeartCathedral : ContentPage
	{
		public SacredHeartCathedral ()
		{
			InitializeComponent ();
		}
        private async void openMap(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.859445156352805, 18.42547782329935);
        }
        private async void openMore(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://katedrala-sarajevo.com/"));
        }
    }
}