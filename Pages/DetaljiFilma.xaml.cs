using Microsoft.Maui.Controls;
using Cinestar2.Models;
using System;

namespace Cinestar2.Pages
{
    public partial class DetaljiFilma : ContentPage
    {
        private int brojKarata = 0;
        private decimal cijenaKarte = 10.0m;

        public DetaljiFilma()
        {
            InitializeComponent();

            
            BrojKarataLabel.Text = "0";
            AzurirajIznos();
        }

        public DetaljiFilma(Film film) : this()
        {
            BindingContext = film;

            NaslovLabel.Text = film.Naziv;
            GodinaLabel.Text = $"Godina: {film.Godina}";
            PosterImage.Source = film.Slika?.ToString();
            TrajanjeLabel.Text = $"Trajanje: {film.Trajanje} min";
            OcjenaLabel.Text = $"Ocjena: {film.Ocjena}";
            OpisLabel.Text = $"Opis: {film.Opis}";
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
            brojKarata++;
            BrojKarataLabel.Text = brojKarata.ToString();
            AzurirajIznos();
        }

        private void Minus_Clicked(object sender, EventArgs e)
        {
            if (brojKarata > 0)
            {
                brojKarata--;
                BrojKarataLabel.Text = brojKarata.ToString();
                AzurirajIznos();
            }
        }

        private void AzurirajIznos()
        {
            decimal iznos = brojKarata * cijenaKarte;
            IznosLabel.Text = $"{iznos} KM";
        }

        private async void Kupi_Clicked(object sender, EventArgs e)
        {
            if (brojKarata == 0)
            {
                await DisplayAlert("Greška", "Odaberite barem jednu kartu.", "OK");
                return;
            }

            decimal iznos = brojKarata * cijenaKarte;

            await Shell.Current.GoToAsync(
                $"{nameof(AddCardPage)}" +
                $"?film={Uri.EscapeDataString(NaslovLabel.Text)}" +
                $"&kolicina={brojKarata}" +
                $"&iznos={iznos}"
            );
        }

        

        private async void Trailer_Clicked(object sender, EventArgs e)
        {
            if (BindingContext is Film film && film.TrailerUrl != null)
            {
                TrailerWebView.Source = film.TrailerUrl.ToString();
                TrailerWebView.IsVisible = true;
            }
            else
            {
                await DisplayAlert("Greška", "Trailer nije dostupan.", "OK");
            }
        }
    }
}
