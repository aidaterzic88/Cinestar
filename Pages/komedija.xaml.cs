using Microsoft.Maui.Controls;
using System.Collections.Generic;
using Cinestar2.Models;
using Cinestar2.Pages;   // BITNO: za DetaljiFilma

namespace Cinestar2
{
    public partial class Komedija : ContentPage
    {
        public Komedija()
        {
            InitializeComponent();
            ListaFilmova.ItemsSource = DohvatiFilmove();
        }

        private List<Film> DohvatiFilmove()
        {
            return new List<Film>
            {
                new Film { Naziv="The Hangover", Godina="2009", Slika="hangover.jpg" , TrailerUrl=new Uri("https://youtu.be/TZc39afdeXU?si=Lwi1t9GPtK9L1y1Y") },
                new Film { Naziv="Friends: The Movie", Godina="2024", Slika="friends.jpg" , TrailerUrl=new Uri("https://youtu.be/Zg2LCD5QOJs?si=OQYxr575KlYcUt2v") }
            };
        }

        // OVO JE KLJUČNA METODA
        private async void Film_Tapped(object sender, EventArgs e)
        {
            var frame = sender as Frame;

            if (frame?.BindingContext is Film film)
            {
                // Navigacija na ISTU DetaljiFilma stranicu
                await Navigation.PushAsync(new DetaljiFilma(film));
            }
        }
    }
}
