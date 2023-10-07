using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace SarajExplore
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RentCarPopup : Popup
	{
		public RentCarPopup ()
		{
			InitializeComponent ();
		}

        private void exitPopup(object sender, EventArgs e)
        {
            Dismiss(null);
        }
        private async void rentalCars(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://www.rentalcars.com/"));
        }
        private async void bihamk(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://bihamk.ba/"));
        }
    }
}