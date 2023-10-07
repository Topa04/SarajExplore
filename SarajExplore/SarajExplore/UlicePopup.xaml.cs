using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SarajExplore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UlicePopup : Popup
    {
        int broj = 0;
        public UlicePopup(int prosBroj)
        {
            InitializeComponent();
            broj= prosBroj;
            prikazTeksta();
        }
        public void prikazTeksta()
        {
            if (broj == 10)
            {
                naslov.Text = "Sarači Street";
                tekst1.Text = "This street begins where the Ferhadija ends, near the Slatko ćoše, and stretches all the way to the Baščaršija Square and Sebilj. This street has changed since it was made, but it always represents a postcard of Sarajevo from the Ottoman period, given the characteristic architecture of the surrounding buildings from that period.";
                tekst2.Text = "Numerous stores with traditional artisanal products stretch along Sarači. The present promenade was named after those stores. The street was named after sarači, the oldest craftsmen who appeared in 1489 and who made different products of leather, mostly horse equipment, as well as equipment for passengers, clogs and peasant shoes.";
                tekst3.Text = "Sarači are an essential destination for tourists during the visit to the capital of BiH, and the people of Sarajevo also enjoy walking down this part of the city, drinking coffee, eating cake in nearby cafes, or buying something in numerous and varied stores.";
                slika1.Source = "sar2.jpg";
                slika2.Source = "sar3.jpg";
                okvir.BackgroundColor = Color.FromHex("#e6e6e6");
            }
            if (broj == 11)
            {
                naslov.Text = "Kazandžiluk Street";
                tekst1.Text = "Kazandžiluk is a historic street located in the heart od Sarajevo. The name ˝Kazdandžiluk¨ tranlates to ¨Coppersmith Street¨ in English, reflecting its rich history and traditional craft. The street is lined with small workshops and stores where skileed artisans practice the centruries-old craft of copper and metalwork.";
                tekst2.Text = "Visitors to Kazandžiluk can witness the artisans hammering, shaping and etching intricate designs onto pots, trays and other coperware. The charming cobblestone street is alson known for its vibrant atmosphere, with shops selling traditional Bosnian handicrafs, souvenirs and local delicacies.";
                tekst3.Text = "Kazandžiluk is not only a hub for traditional craftmanship but also a popular tourist destination, attracting both locals and visitors from around the world. Ecploring Kazandžiluk offers a glimpse into Sarajevo's rich cultural heritage and provides an opportunity to appreciate the skill and artistry of the local artisans.";
                slika1.Source = "kaz2.jpg";
                slika2.Source = "kaz3.jpg";
                okvir.BackgroundColor = Color.FromHex("#e6e6e6");
            }
            if (broj == 12)
            {
                naslov.Text = "Kovači Street";
                tekst1.Text = "Kovači is a neighborhood located in the ols part of Sarajevo. Situated on the hillside, Kovači offers breathtaking panoramic views od the city and its surronding mountains. The neighborhood is known for its narrow, winding streets, stones houses and Ottoman-era architecture, which gives it a distinct charm and historical appeal.";
                tekst2.Text = "Kovači is home to several important landmarks, including the Scred Heart Cathedral, a magnigicent Catholic church that stands as one od Sarajevo's architectural gems. The area also houses the Academy od Fine Arts, adding an artistic flair to the neighborhood with its creative energy and exhibitions. ";
                tekst3.Text = "Kovači is well-connected to other parts od the city, making it convenient for residents and visitors to explore Sarajevo's cultural and historical attractions. With its blend of history, sunning views, and cultural significance, Kovači offers a unique experience and serves as a testament to Sarajevo's diverse heritage.";
                slika1.Source = "kov2.jpg";
                slika2.Source = "kov3.jpg";
                okvir.BackgroundColor = Color.FromHex("#e6e6e6");
            }
        }
        private void Back(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}