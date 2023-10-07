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
    public partial class GaziHusrevBeg : ContentPage
    {
        public GaziHusrevBeg()
        {
            InitializeComponent();
        }
        private async void openMap(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.85904098026147, 18.429119937519193);
        }

        private async void openMore(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://begovadzamija.ba/turizam/"));
        }
    }
}