using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace SarajExplore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vijecnica : ContentPage
    {
        public Vijecnica()
        {
            InitializeComponent();
        }

        private async void openMap(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.859108, 18.433378);
        }

        private async void openMore(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://www.vijecnica.ba/"));
        }
    }
}