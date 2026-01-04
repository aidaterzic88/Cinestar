using Microsoft.Maui.Controls;
using System.Collections.Generic;
using Cinestar2.Models;

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
                new Film { Naziv="The Hangover", Godina="2009", Slika="hangover.jpg" },
                new Film { Naziv="Friends: The Movie", Godina="2024", Slika="friends.jpg" }
            };
        }
    }
}
