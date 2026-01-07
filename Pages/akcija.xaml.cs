using Microsoft.Maui.Controls;
using System.Collections.Generic;
using Cinestar2.Models;
using Cinestar2.Pages;

namespace Cinestar2
{
    public partial class Akcija : ContentPage
    {
        public Akcija()
        {
            InitializeComponent();
            ListaFilmova.ItemsSource = DohvatiFilmove();
        }

        private List<Film> DohvatiFilmove()
        {
            return new List<Film>
            {
                new Film { Naziv="John Wick", Godina="2014", Slika="johnwick.jpg", TrailerUrl=new Uri("https://youtu.be/C0BMx-qxsP4?si=6Yb6rG3gbN45U1YL") },
                new Film { Naziv="Mad Max", Godina="2015", Slika="madmax.jpg" , TrailerUrl=new Uri("https://youtu.be/hEJnMQG9ev8?si=UqIryoGz6FmZ2eNd")}
            };
        }

        private async void Film_Tapped(object sender, EventArgs e)
        {
            var frame = sender as Frame;
            var film = frame?.BindingContext as Film;

            if (film != null)
            {
                await Navigation.PushAsync(new DetaljiFilma(film));
            }
        }
    }
}
