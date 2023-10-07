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
	public partial class Tour1 : ContentPage
	{
		public Tour1 ()
		{
			InitializeComponent ();
        }
        private void day1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tour1Day1());
        }
    }
}