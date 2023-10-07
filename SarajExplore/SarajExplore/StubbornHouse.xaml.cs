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
    public partial class StubbornHouse : ContentPage
    {
        public StubbornHouse()
        {
            InitializeComponent();
        }
        private async void openMap(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.85855457333287, 18.43428821624128);
        }

        private async void openMore(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("http://furaj.ba/inat-kuca/"));
        }
    }
}