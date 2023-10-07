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
    public partial class Promenade : ContentPage
    {
        public Promenade()
        {
            InitializeComponent();
        }

        private async void showMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            if (dugme.TabIndex == 0)
            {
                await Map.OpenAsync(43.86041723774434, 18.437295485561037);
            }
            else if (dugme.TabIndex == 1)
            {
                await Map.OpenAsync(43.853620155208915, 18.40639467602581);
            }
            else if (dugme.TabIndex == 2)
            {
                await Map.OpenAsync(43.818795816300984, 18.269328354314457);
            }else if(dugme.TabIndex == 3)
            {
                await Launcher.OpenAsync(new Uri("https://kofer.info/vrelo-bosne/"));
            }
        }
    }
}