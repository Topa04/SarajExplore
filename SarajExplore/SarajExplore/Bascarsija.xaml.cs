using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SarajExplore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bascarsija : ContentPage
    {
        public Bascarsija()
        {
            InitializeComponent();
        }
        private async void openMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            if (dugme.TabIndex==20)
            {
                await Map.OpenAsync(43.859483795279644, 18.429487610702772);
            }
            else if(dugme.TabIndex == 21)
            {
                await Map.OpenAsync(43.85926502350014, 18.431484491553935);
            }
            else if (dugme.TabIndex == 22)
            {
                await Map.OpenAsync(43.860292124488595, 18.43217425390614);
            }
        }
        private void openPopup(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            Navigation.ShowPopup(new UlicePopup(dugme.TabIndex)) ;
        }
    }
}