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
	public partial class EternalFlame : ContentPage
	{
		public EternalFlame ()
		{
			InitializeComponent ();
		}
        private async void openMap(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.85881787059832, 18.421844962988093);
        }
    }
}