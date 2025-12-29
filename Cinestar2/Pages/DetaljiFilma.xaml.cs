using Microsoft.Maui.Controls;
using Cinestar2.Models;

namespace Cinestar2.Pages
{
    public partial class DetaljiFilma : ContentPage
    {
        public DetaljiFilma(Film film)
        {
            
        }

        private async void KupiKarte_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Kupovina karata", "Funkcija kupovine još nije implementirana.", "OK");
        }
    }
}
