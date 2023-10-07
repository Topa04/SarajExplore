using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace SarajExplore
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransportPopup : Popup
	{
        int broj = 0;
        public TransportPopup (int prosBroj)
		{
			InitializeComponent ();
            broj = prosBroj;
            content();
        }
        private void content()
        {
            if (broj == 0)
            {
                naslov.Text = "BAŠČARŠIJA – ŽELJEZNIČKA STANICA";
                cijena1.Text = "Monday – Saturday \r\n06:17; 06:33; 07:05; 07:37; 08:09; 08:41; 09:13; 09:45; 10:17; 10:33; 11:05; 11:37; 12:09; 12:41; 13:13; 13:45; 14:17; 14:49; 15:05; 15;37; 16:09; 16:41; 17:13; 17:45; 18:17; 18:43; 19:15; 19:47; 20:03; 20:35; 21:07; 21:39\r\nSunday\r\n07:07; 08:11; 09:07; 10:19; 11:31; 12:07; 13;19; 14:31; 15:07; 16:19; 17:31; 18:07; 19:02; 20:14; 20:50; 21:26";
                cijena2.Text = "Ticket price: 1.40 KM";
                slika1.Source = "baszelj.jpg";
                info.IsVisible = false;
                tekst.IsVisible = false;
                tekst2.IsVisible = false;
                slika2.IsVisible = false;
            }else if (broj==1)
            {
                naslov.Text = "BAŠČARŠIJA – HRASNICA";
                cijena1.Text = "Monday – Friday\r\n05:55; 06:15; 06:35; 06:55; 07:15; 07:35; 07:55; 08:15; 08:35; 08:55; 09:25; 09:55; 10:25; 10:55; 11:25; 11:55; 12:25; 12:55; 13:25; 13:35; 13:55; 14:25; 14:35; 14:55; 15:25; 15:35; 15:55; 16:25; 16:35; 16:55; 17:25; 17:55; 18:25; 18:55; 19:25; 19:55; 20:25; 20:55; 21:55; 22:55\r\nWeekend\r\n05:55; 06:55; 07:55; 09:55; 09:55; 10:55; 11:55; 12:55; 13:55; 14:55; 15:55; 16:55; 17:55; 18:55; 19:55; 20:55; 21:55; 22:55";
                cijena2.Text = "Ticket price: 1.40 KM";
                slika1.Source = "bashra.jpg";
                slika1.HeightRequest= 300;
                info.IsVisible = false;
                tekst.IsVisible = false;
                tekst2.IsVisible = false;
                slika2.IsVisible = false;
            }
            else if (broj == 2)
            {
                naslov.Text = "VIJEĆNICA – DOBRINJA";
                cijena1.Text = "Monday – Friday\r\n06:20; 06:40; 07:00; 07:20: 07:40; 08:00; 08:20: 08:40; 09:00: 09:30; 10:00: 10:30; 11:00: 11:30; 12:00: 12:30; 13:00: 13:30; 14:00; 14:20; 14:40; 15:00; 15:20; 15:40; 16:00; 16:20; 16:40; 17:00: 17:30; 18:00: 18:30; 19:00: 19:30; 20:00; 21:00; 22:00; 23:00; 00:00; 01:00\r\nWeekend\r\n07:00; 08:00; 09:00: 10:00; 11:00; 12:00; 13:00; 14:00; 15:00; 16:00; 17:00; 18:00; 19:00; 20:00; 21:00; 22:00; 23:00; 00:00; 01:00";
                cijena2.Text = "Ticket price: 2.00 KM";
                slika1.Source = "basdbr.jpg";
                slika1.HeightRequest = 200;
                info.IsVisible = false;
                tekst.IsVisible = false;
                tekst2.IsVisible = false;
                slika2.IsVisible = false;
            }
            else if (broj == 3)
            {
                naslov.Text = "BENTBAŠA – AERODROM";
                cijena1.Text = "Every day \r\n06:55; 09:30; 11:40; 13:40; 15:20; 17:10; 18:40; 20:55; 22:30";
                cijena2.Text = "Ticket price: 2.00 KM";
                slika1.Source = "benaero.jpg";
                slika1.HeightRequest = 200;
                info.IsVisible = false;
                tekst.IsVisible = false;
                tekst2.IsVisible = false;
                slika2.IsVisible = false;
            }
            else if (broj == 4)
            {
                naslov.Text = "TRAIN: SARAJEVO – MOSTAR ";
                cijena1.Text = "Ticket price: one-way ticket 25 KM; a return ticket 41.40 KM 30% discount (srudents, journalists, pensioners and groups of over 6 adult passengers): one-way ticket: 18.60 KM; a return tcket 37.20 KM 50% discount (children aged 4 to 12, blind persons and their companions, groups od over 30 adult passenfers): one-way ticket 14.30 KM; a return ticket 28.60 KM";
                cijena2.Text = "Ticket can be paid in convertible marks (KM) or in euros (€). Sarajevo –> Ploče –> Sarajevo tickets cannot be purchased online.";
                cijena2.TextColor = Color.Red;
                info.IsVisible = true;
                info.Text = "Passengers who want to travel by this train should buy a tran ticket no later than the day before the planned journey until 12 o'clock and on that occasion leave the following information: name and surname, year of birth and passport number. Tickets can be purchased ar sales points in Sarajevo, Hadžiči, Konjic, Mostar i Čapljina. If the pssenger stars his journey in Ploče, he will buy the ticket on the day of the journey from the train conductor.";
                slika1.Source = "voz.jpeg";
                tekst.IsVisible = true;
                tekst.Text = "The train journey from Sarajevo to Mostar is a picturesque and wnchanting experience that takes you through the heart od Bosnia and Herzegovina. As the train snakes its way along the rugged terraing, passengers are treated to breathtaking views od majestic mountains, lush valleys and quaint villages nestled in the countryside. The route not only connects two od Bosnia's most historic and culturally rich cities but also affers a glimpse into the natural beauty that defines this captivating Balkan region.";
                slika2.IsVisible = true;
                slika2.Source = "voz2.jpeg";
                tekst2.IsVisible = true;
                tekst2.Text = "The Railways of the Federation of BiH informs the public that the seasonal passenger train Sarajevo – Ploče – Sarajevo will operate again in the period from June 2. until 27.08.2023. traffic will take place on Fridays, Saturdays and Sundays. The departure od the traing from Sarajevo is planned at 07:15 adn the arrival in Ploče at 10:36. The return od the train from Ploče is plannet at 6:26 p.m. and the arrival in Sarajevo at 9:51 p.m.";
            }

        }
        private void exitPopup(object sender, EventArgs e)
        {
            Dismiss(null);
        }

        private async void startingPos(object sender, EventArgs e)
        {
            if (broj==0)
            {
                await Map.OpenAsync(43.8595701399384, 18.433394999832633);
            }
            else if(broj==1)
            {
                await Map.OpenAsync(43.8595701399384, 18.433394999832633);
            }
            else if(broj==2) 
            {
                await Map.OpenAsync(43.8595701399384, 18.433394999832633);
            }
            else if (broj == 3)
            {
                await Map.OpenAsync(43.85934187599019, 18.434577635414467);
            }
            else if (broj == 4)
            {
                await Map.OpenAsync(43.86020125769689, 18.39950240995502);
            }

        }
    }
}