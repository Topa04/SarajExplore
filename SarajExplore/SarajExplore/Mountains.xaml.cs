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
    public partial class Mountains : ContentPage
    {
        public Mountains()
        {
            InitializeComponent();
        }

        private async void showMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch(dugme.TabIndex)
            {
                case 0:
                    await Map.OpenAsync(43.721112943278776, 18.28282625682817);
                    break;
                case 1:
                    await Map.OpenAsync(43.73782514584973, 18.567338809732842);
                    break;
                case 2:
                    await Map.OpenAsync(43.84137380318962, 18.414579857259238);
                    break;
                case 3:
                    await Map.OpenAsync(43.74792634541739, 18.26514870214587);
                    break;
                case 10:
                    await Launcher.OpenAsync(new Uri("https://bjelasnica.ba/"));
                    break; 
                case 11:
                    await Launcher.OpenAsync(new Uri("https://www.oc-jahorina.com/"));
                    break;
                case 12:
                    await Launcher.OpenAsync(new Uri("https://putovanjazapet.com/mjesto-relaksirajuce-prirode-i-izvanrednih-aktivnosti-trebevic/"));
                    break;
                case 13:
                    await Launcher.OpenAsync(new Uri("http://furaj.ba/planina-igman-nadomak-sarajeva/"));
                    break;
                case 20:
                    await Launcher.OpenAsync(new Uri("https://www.ski.ba/category/live-stream/"));
                    break;
                case 21:
                    await Launcher.OpenAsync(new Uri("https://www.oc-jahorina.com/web-kamere/"));
                    break;
                case 22:
                    await Launcher.OpenAsync(new Uri("https://jahorinaprestige.com/web-camera-brus-trebevic/"));
                    break;
                case 23:
                    await Launcher.OpenAsync(new Uri("https://hr.bergfex.com/malo-polje-igman/webcams/c16730/"));
                    break;
            }
            
        }
    }
}