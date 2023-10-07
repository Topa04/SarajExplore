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
    public partial class Nature : ContentPage
    {
        public Nature()
        {
            InitializeComponent();
        }

        private void mountainsMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mountains());
        }
        private void promenadeMore(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Promenade());
        }
    }
}