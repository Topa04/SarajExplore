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
	public partial class Titova : ContentPage
	{
		public Titova ()
		{
			InitializeComponent ();
		}
        private async void openMap(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.858886414269406, 18.42147113965408);
            
        }
    }
}