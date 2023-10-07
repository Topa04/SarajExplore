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
    public partial class Sebilj : ContentPage
    {
        public Sebilj()
        {
            InitializeComponent();
        }

        private async void openMap(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.859674269087215, 18.431248935496892);
        }
    }
}