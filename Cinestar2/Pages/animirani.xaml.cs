using Microsoft.Maui.Controls;
using System.Collections.Generic;
using Cinestar2.Models;

namespace Cinestar2
{
    public partial class Animirani : ContentPage
    {
        public Animirani()
        {
            InitializeComponent();
            ListaFilmova.ItemsSource = DohvatiFilmove();
        }

        private List<Film> DohvatiFilmove()
        {
            return new List<Film>
            {
                new Film { Naziv="Frozen", Godina="2013", Slika="frozen.jpeg" },
                new Film { Naziv="Toy Story", Godina="1995", Slika="toystory.jpg" }
            };
        }
    }
}
