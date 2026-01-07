using Microsoft.Maui.Controls;
using Cinestar2.Models;

namespace Cinestar2.Pages
{
    public partial class DetaljiFilma : ContentPage
    {
        private int brojKarata = 0;
        private decimal cijenaKarte = 10.0m; // npr. 10 KM po karti

        

        public DetaljiFilma(Film film)
        {
            InitializeComponent();
            BindingContext = film;

            // Postavimo podatke filma na UI
            NaslovLabel.Text = film.Naziv;
            OpisLabel.Text = $"Godina: {film.Godina}";
            PosterImage.Source = film.Slika;
            TrajanjeLabel.Text = "Trajanje: 120 min"; // primjer
            OcjenaLabel.Text = "Ocjena: 8.5"; // primjer

            // Prvi prikaz iznosa
            AžurirajIznos();
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
            brojKarata++;
            BrojKarataLabel.Text = brojKarata.ToString();
            AžurirajIznos();
        }

        private void Minus_Clicked(object sender, EventArgs e)
        {
            if (brojKarata > 0)
            {
                brojKarata--;
                BrojKarataLabel.Text = brojKarata.ToString();
                AžurirajIznos();
            }
        }

        private void AžurirajIznos()
        {
            decimal iznos = brojKarata * cijenaKarte;
            IznosLabel.Text = $"{iznos} KM";
        }

        private async void Kupi_Clicked(object sender, EventArgs e)
        {
            if (brojKarata == 0)
            {
                await DisplayAlert("Greška", "Morate odabrati barem jednu kartu!", "OK");
                return;
            }

            decimal iznos = brojKarata * cijenaKarte;
            await DisplayAlert("Kupovina karata", $"Ukupno za platiti: {iznos} KM", "OK");

            // Reset broja karata
            brojKarata = 0;
            BrojKarataLabel.Text = "0";
            AžurirajIznos();
        }

        private async void Nazad_Clicked(object sender, EventArgs e)
        {
            // Ako stranica dolazi iz navigacije
            await Navigation.PopAsync();
        }

        private async void Trailer_Clicked(object sender, EventArgs e)
        {
            if (BindingContext is Film film && film.TrailerUrl != null)
            {
                TrailerWebView.Source = film.TrailerUrl;
                TrailerWebView.IsVisible = true;
            }
            else
            {
                await DisplayAlert("Greška", "Trailer nije dostupan.", "OK");
            }
        }




    }
}
