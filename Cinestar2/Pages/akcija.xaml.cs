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

            ListaFilmova.SelectionChanged += ListaFilmova_SelectionChanged;
        }

        private List<Film> DohvatiFilmove()
        {
            return new List<Film>
            {
                new Film { Naziv = "Avengers", Godina = "2019", Slika = "avengers.jpg" },
                new Film { Naziv = "Deadpool", Godina = "2016", Slika = "deadpool.jpg" },
                new Film { Naziv = "Fast & Furious", Godina = "2021", Slika = "fastfurious.jpg" }
            };
        }

        private async void ListaFilmova_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var odabraniFilm = e.CurrentSelection[0] as Film;
                if (odabraniFilm != null)
                {
                    var detaljiStranica = new DetaljiFilma(odabraniFilm);
                    await Navigation.PushAsync(detaljiStranica); 
                }

                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}
