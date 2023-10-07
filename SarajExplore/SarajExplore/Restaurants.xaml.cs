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
	public partial class Restaurants : ContentPage
	{
		public Restaurants ()
		{
			InitializeComponent ();
		}

        private async void openMore(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 10:
                    await Launcher.OpenAsync(new Uri("https://parkprinceva.ba/")); 
                    break;
                case 11:
                    await Launcher.OpenAsync(new Uri("https://baoli.ba/ ")); 
                    break;
                case 12:
                    await Launcher.OpenAsync(new Uri("https://restoran-amerikanac-sarajevo.business.site/"));
                    break;
                case 13:
                    await Launcher.OpenAsync(new Uri("https://restoransarajevo.com/"));
                    break;
                case 14:
                    await Launcher.OpenAsync(new Uri("https://www.facebook.com/gastropubvucko")); 
                    break;
                case 15:
                    await Launcher.OpenAsync(new Uri("https://doshermanos.ba/"));
                    break;
                case 16:
                    await Launcher.OpenAsync(new Uri("https://www.ribnjaktoplik.ba/")); 
                    break;
                case 17:
                    await Launcher.OpenAsync(new Uri("https://ba.vapiano.com/bs/home/"));
                    break;
            }
        }
        private async void openMenu(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 20:
                    await Launcher.OpenAsync(new Uri("https://parkprinceva.ba/main-courses/"));
                    break;
                case 21:
                    await Launcher.OpenAsync(new Uri("https://baoli.ba/index.php#menu "));
                    break;
                case 22:
                    await Launcher.OpenAsync(new Uri("https://www.facebook.com/restoranAmerikanac/menu/"));
                    break;
                case 23:
                    await Launcher.OpenAsync(new Uri("https://restoransarajevo.com/wp-content/uploads/2023/03/menu_08_03-2.pdf"));
                    break;
                case 24:
                    await Launcher.OpenAsync(new Uri("https://glovoapp.com/ba/hr/sarajevo/gastro-pub-vucko-radieva/?utm_source=google&utm_medium=cpc&utm_campaign=google_brandprotection_ME_ALL_Search_ImpS_All_ImpressionShare_BrandProtection_AllUsers_Exact_BrandingAlwaysOn_DigitalBudget_0_02052021&utm_campaignid=12711029237&utm_adgroupid=125730636873&utm_term&utm_matchtype&utm_device=c&gclid=Cj0KCQjwmtGjBhDhARIsAEqfDEckeg36XvosEwuj1qkyYvti-RpuKwvpkzSkgI1bgnI0ajugwhHBkNsaAoKEEALw_wcB"));
                    break;
                case 25:
                    await Launcher.OpenAsync(new Uri("https://doshermanos.ba/menu-restoran-dos-hermanos/"));
                    break;
                case 26:
                    await Launcher.OpenAsync(new Uri("https://www.ribnjaktoplik.ba/wp-content/uploads/2022/09/Meni-sa-alergenima-2022.pdf"));
                    break;
                case 27:
                    await Launcher.OpenAsync(new Uri("https://ba.vapiano.com/bs/meni/antipasti-insalata/"));
                    break;
            }
        }
        private async void openMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 30:
                    await Map.OpenAsync(43.85370636869821, 18.436484289564923);
                    break;
                case 31:
                    await Map.OpenAsync(43.8637216734552, 18.415737835823897);
                    break;
                case 32:
                    await Map.OpenAsync(43.85831680930789, 18.41824837398091);
                    break;
                case 33:
                    await Map.OpenAsync(43.86411661771477, 18.414910289147524);
                    break;
                case 34:
                    await Map.OpenAsync(43.858542916352825, 18.417524340573568);
                    break;
                case 35:
                    await Map.OpenAsync(43.857241548490194, 18.41803148456091);
                    break;
                case 36:
                    await Map.OpenAsync(43.81080248601233, 18.388922831545443);
                    break;
                case 37:
                    await Map.OpenAsync(43.856326926036935, 18.405550984956307);
                    break;
            }
        }
    }
}