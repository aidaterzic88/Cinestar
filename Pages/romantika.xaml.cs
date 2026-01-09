using Microsoft.Maui.Controls;
using Cinestar2.Models;
using Cinestar2.Pages;
using System.Collections.Generic;

namespace Cinestar2
{
    public partial class Romantika : ContentPage
    {
        public Romantika()
        {
            InitializeComponent();
            ListaFilmova.ItemsSource = DohvatiFilmove();
        }

        private List<Film> DohvatiFilmove()
        {
            return new List<Film>
            {
                new Film { Naziv="Crazy Rich Asians", Godina="2018", Slika="crazyrich.jpg" , TrailerUrl=new Uri("https://youtu.be/ZQ-YX-5bAs0?si=R2rKYYeiFKJ5GDFl")},
                new Film { Naziv="La La Land", Godina="2016", Slika="lalaland.jpg" , TrailerUrl=new Uri("https://youtu.be/0pdqf4P9MB8?si=tocIhDUopzNY8JVg")}
            };
        }

        private async void Film_Tapped(object sender, EventArgs e)
        {
            // Dobijamo Film iz BindingContexta
            var frame = sender as Frame;
            if (frame?.BindingContext is Film odabraniFilm)
            {
                // Kreiramo stranicu i prosljeđujemo film
                var detaljiStranica = new DetaljiFilma(odabraniFilm);
                await Navigation.PushAsync(detaljiStranica);
            }
        }
    }
}
