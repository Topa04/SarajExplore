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
    public partial class Culture : ContentPage
    {
        public Culture()
        {
            InitializeComponent();
        }

        private void vijecnicaMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Vijecnica());
        }
        private void inatkucaMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StubbornHouse());
        }
        private void sebiljMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sebilj());
        }
        private void bascarsijaMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bascarsija());
        }
        private void ghbmMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GaziHusrevBeg());
        }
        private void shkatedralaMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SacredHeartCathedral());
        }
        private void katedralaMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CathedralChurch());
        }
        private void titovaMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Titova());
        }
        private void vatraMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EternalFlame());
        }
        private void museumMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Museums());
        }
    }
}