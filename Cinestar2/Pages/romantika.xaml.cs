using Microsoft.Maui.Controls;
using System.Collections.Generic;
using Cinestar2.Models;

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
                new Film { Naziv="Crazy Rich Asians", Godina="2018", Slika="crazyrich.jpg" },
                new Film { Naziv="La La Land", Godina="2016", Slika="lalaland.jpg" }
            };
        }
    }
}
