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
    public partial class Hotel : ContentPage
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private async void openMap(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch(dugme.TabIndex)
            {
                case 20:
                    await Map.OpenAsync(43.85834096411856, 18.427445225391057);
                    break;
                case 21:
                    await Map.OpenAsync(43.85517268010304, 18.407378916390478);
                    break;
                case 22:
                    await Map.OpenAsync(43.82681433009383, 18.312444615089685);
                    break;
                case 23:
                    await Map.OpenAsync(43.855624596376565, 18.41525628751315);
                    break;
                case 24:
                    await Map.OpenAsync(43.85785720206942, 18.42599047034646);
                    break;
                case 25:
                    await Map.OpenAsync(43.85825516088031, 18.430152986921748);
                    break;
                case 26:
                    await Map.OpenAsync(43.863180389193786, 18.436161113584834);
                    break;
                case 27:
                    await Map.OpenAsync(43.858667893582755, 18.428901863084423);
                    break;

            }
        }
        private async void openLink(object sender, EventArgs e)
        {
            var dugme = sender as Button;
            switch (dugme.TabIndex)
            {
                case 10:
                    await Launcher.OpenAsync(new Uri("https://www.booking.com/hotel/ba/europa-sarajevo.en-gb.html?aid=376363&label=booking-name-L%2AXf2U1sq4%2AGEkIwcLOALQS267777916057%3Apl%3Ata%3Ap1%3Ap22%2C563%2C000%3Aac%3Aap%3Aneg%3Afi%3Atikwd-65526620%3Alp20079%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YfqnDqqG8nt1XFzPnqOODws&sid=8efd1d7dc54ee6e5f272f7ed1aa7f01b&all_sr_blocks=25864506_265547350_0_1_0;checkin=2023-06-12;checkout=2023-06-13;dist=0;group_adults=2;group_children=0;hapos=2;highlighted_blocks=25864506_265547350_0_1_0;hpos=2;matching_block_id=25864506_265547350_0_1_0;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=distance_from_search;sr_pri_blocks=25864506_265547350_0_1_0__14725;srepoch=1685280048;srpvid=238e5dd45f16002b;type=total;ucfs=1&#hotelTmpl"));
                    break;
                case 11:
                    await Launcher.OpenAsync(new Uri("https://www.booking.com/hotel/ba/swissotel-sarajevo.en-gb.html?aid=376363&label=booking-name-L%2AXf2U1sq4%2AGEkIwcLOALQS267777916057%3Apl%3Ata%3Ap1%3Ap22%2C563%2C000%3Aac%3Aap%3Aneg%3Afi%3Atikwd-65526620%3Alp20079%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YfqnDqqG8nt1XFzPnqOODws&sid=8efd1d7dc54ee6e5f272f7ed1aa7f01b&all_sr_blocks=357043303_246029814_2_1_0;checkin=2023-06-12;checkout=2023-06-13;dest_id=3570433;dest_type=hotel;dist=0;group_adults=2;group_children=0;hapos=1;highlighted_blocks=357043303_246029814_2_1_0;hpos=1;matching_block_id=357043303_246029814_2_1_0;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=popularity;sr_pri_blocks=357043303_246029814_2_1_0__17000;srepoch=1685280399;srpvid=a1885e86c95c02d6;type=total;ucfs=1&#hotelTmpl"));
                    break;
                case 12:
                    await Launcher.OpenAsync(new Uri("https://www.booking.com/hotel/ba/hills-sarajevo-congress-amp-thermal-spa-resort.hr.html?aid=333370&label=hills-sarajevo-congress-amp-thermal-spa-resort-aWCsL1iLmu2Y2kzWON0bhgS161712910532%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atiaud-146342137510%3Akwd-7233512267%3Alp9298294%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Ye7BFAsTyVd6FoONnMy1LEw&sid=8efd1d7dc54ee6e5f272f7ed1aa7f01b&all_sr_blocks=175204202_265094808_0_41_0;checkin=2023-06-12;checkout=2023-06-13;dest_id=-94996;dest_type=city;dist=0;group_adults=2;group_children=0;hapos=1;highlighted_blocks=175204202_265094808_0_41_0;hpos=1;matching_block_id=175204202_265094808_0_41_0;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=popularity;sr_pri_blocks=175204202_265094808_0_41_0__12060;srepoch=1685280535;srpvid=ea8b5eca539c0199;type=total;ucfs=1&#hotelTmpl"));
                    break;
                case 13:
                    await Launcher.OpenAsync(new Uri("https://www.booking.com/hotel/ba/courtyard-by-marriott-sarajevo.en-gb.html?aid=376363&label=booking-name-L%2AXf2U1sq4%2AGEkIwcLOALQS267777916057%3Apl%3Ata%3Ap1%3Ap22%2C563%2C000%3Aac%3Aap%3Aneg%3Afi%3Atikwd-65526620%3Alp20079%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YfqnDqqG8nt1XFzPnqOODws&sid=8efd1d7dc54ee6e5f272f7ed1aa7f01b&all_sr_blocks=132893702_94588392_2_2_0;checkin=2023-06-12;checkout=2023-06-13;dist=0;group_adults=2;group_children=0;hapos=1;highlighted_blocks=132893702_94588392_2_2_0;hpos=1;matching_block_id=132893702_94588392_2_2_0;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=distance_from_search;sr_pri_blocks=132893702_94588392_2_2_0__12510;srepoch=1685281284;srpvid=d5bb6041a3e801de;type=total;ucfs=1&#hotelTmpl"));
                    break;
                case 14:
                    await Launcher.OpenAsync(new Uri("https://www.booking.com/hotel/ba/central.hr.html?ws=;gclid=Cj0KCQjw98ujBhCgARIsAD7QeAjKR1fNTrR64owM7uqXSaUfsT0gG_CuPulI4DsBdk71gyYDWRf_xUAaAl9QEALw_wcB;aid=1486641;label=hotel-central-sarajevo-HR-S604151712853%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-1598420319296%3Alp9298294%3Ali9298294%3Adec%3Adm"));
                    break;
                case 15:
                    await Launcher.OpenAsync(new Uri("https://www.booking.com/hotel/ba/president-sarajevo.en-gb.html?aid=311984&label=president-sarajevo-vW0a56Nt6jHundNZHWb_bwS392944349647%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-107935074806%3Alp9298294%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YXwxhKG0pUU-mcMVT-JwQpc&sid=8efd1d7dc54ee6e5f272f7ed1aa7f01b&all_sr_blocks=141940901_270503249_0_1_0;checkin=2023-06-12;checkout=2023-06-13;dest_id=-94996;dest_type=city;dist=0;group_adults=2;group_children=0;hapos=1;highlighted_blocks=141940901_270503249_0_1_0;hpos=1;matching_block_id=141940901_270503249_0_1_0;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=popularity;sr_pri_blocks=141940901_270503249_0_1_0__13050;srepoch=1685281791;srpvid=f253613ec4f801a8;type=total;ucfs=1&#hotelTmpl "));
                    break;
                case 16:
                    await Launcher.OpenAsync(new Uri("https://www.booking.com/hotel/ba/quot-aziza-quot.en-gb.html?aid=333757&label=ba-sarajevo-dxHaJuDz_s72YcQlrTp5HQS469412970197%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atiaud-1110454565747%3Akwd-298596502937%3Alp9298294%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9Ya3yBIgOvqZEklAHMNd68mc&sid=8efd1d7dc54ee6e5f272f7ed1aa7f01b&all_sr_blocks=210086903_0_2_0_0;checkin=2023-06-12;checkout=2023-06-13;dest_id=2100869;dest_type=hotel;dist=0;group_adults=2;group_children=0;hapos=1;highlighted_blocks=210086903_0_2_0_0;hpos=1;matching_block_id=210086903_0_2_0_0;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=popularity;sr_pri_blocks=210086903_0_2_0_0__6757;srepoch=1685359323;srpvid=ca3b4fecc9a7014b;type=total;ucfs=1&#hotelTmpl"));
                    break;
                case 17:
                    await Launcher.OpenAsync(new Uri("https://www.booking.com/hotel/ba/old-town.hr.html?aid=333365&label=sarajevo%2Foldtown-bascarsija-edumtN0ffiGQaSMwp21uaAS624599418877%3Apl%3Ata%3Ap1200%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atiaud-146342137510%3Akwd-12203628279%3Alp9298294%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YboIMJYQAPicltiwyR-Bd14&sid=8efd1d7dc54ee6e5f272f7ed1aa7f01b&all_sr_blocks=9881921_337780705_2_1_0;checkin=2023-06-12;checkout=2023-06-13;dest_id=98819;dest_type=hotel;dist=0;group_adults=2;group_children=0;hapos=1;highlighted_blocks=9881921_337780705_2_1_0;hpos=1;matching_block_id=9881921_337780705_2_1_0;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=popularity;sr_pri_blocks=9881921_337780705_2_1_0__9996;srepoch=1685359830;srpvid=4aaa50eae9560113;type=total;ucfs=1&#hotelTmpl"));
                    break;
            }
        }
    }
}