
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public int Minuty { get; set; }
        public int Sekundy { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Minuty = 0;
            Sekundy = 0;
        }



        private void ButtonClickedReset(object sender, EventArgs e)
        {
            lacznyCzas.Text = "0:00";
            Minuty = 0;
            Sekundy = 0;
        }

        private void ButtonClickedDodajCzas(object sender, EventArgs e)
        {
            if(int.TryParse(minuty.Text, out int minuta)&& int.TryParse(sekundy.Text, out int sekunda ))
            {
                
                Sekundy+= sekunda;
                Minuty+= minuta;
                if(Sekundy>59)
                {
                    Minuty += Sekundy / 60;
                    Sekundy = Sekundy % 60;
                   
                    
                }
                if (Sekundy<10)
                {
                    lacznyCzas.Text = Minuty.ToString() + ":" + "0"+ Sekundy.ToString();
                    return;
                }
                lacznyCzas.Text = Minuty.ToString() + ":" + Sekundy.ToString();
                return;
            }
            else
            {
                DisplayAlert("błąd", "Błedna Wartość", "OK");
                return;
            }
           
        }
    }

}
