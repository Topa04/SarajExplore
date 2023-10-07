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
	public partial class Museums : ContentPage
	{
		public Museums ()
		{
			InitializeComponent ();
		}
        private async void showMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 0:
                    await Map.OpenAsync(43.8550101980742, 18.402515407143955);
                    break;
                case 1:
                    await Map.OpenAsync(43.85475148207276, 18.41859875098057);
                    break;
                case 2:
                    await Map.OpenAsync(43.86191005413898, 18.428416240812673);
                    break;
                case 10:
                    await Launcher.OpenAsync(new Uri("https://www.zemaljskimuzej.ba/"));
                    break;
                case 11:
                    await Launcher.OpenAsync(new Uri("http://moisarajevo.ba/"));
                    break;
                case 12:
                    await Launcher.OpenAsync(new Uri("https://warchildhood.org/"));
                    break;
            }

        }
    }
}