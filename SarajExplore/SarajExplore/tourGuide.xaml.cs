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
    public partial class tourGuide : ContentPage
    {
        public tourGuide()
        {
            InitializeComponent();
        }

        private void culture(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Culture());
        }
        private void nature(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nature());
        }
    }
}