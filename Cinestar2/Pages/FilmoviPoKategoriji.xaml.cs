using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace Cinestar2
{
    public partial class FilmoviPoKategoriji : ContentPage
    {
        public FilmoviPoKategoriji(string kategorija)
        {
            InitializeComponent();

            // Postavi naslov stranice na naziv kategorije
            NaslovKategorije.Text = kategorija;

            // Napravi dummy listu filmova (kasnije možeš povezati s bazom)
            var filmovi = DohvatiFilmovePoKategoriji(kategorija);

            // Poveži CollectionView s listom filmova
            ListaFilmova.ItemsSource = filmovi;
        }

        // Metoda koja vraća listu filmova po kategoriji
        private List<Film> DohvatiFilmovePoKategoriji(string kategorija)
        {
            var sviFilmovi = new List<Film>
            {
                new Film { Naziv="Avengers", Godina="2019", Slika="avengers.png", Kategorija="Akcija" },
                new Film { Naziv="Deadpool", Godina="2016", Slika="deadpool.png", Kategorija="Akcija" },
                new Film { Naziv="The Hangover", Godina="2009", Slika="hangover.png", Kategorija="Komedija" },
                new Film { Naziv="Crazy Rich Asians", Godina="2018", Slika="crazyrich.png", Kategorija="Romantika" },
                new Film { Naziv="Frozen", Godina="2013", Slika="frozen.png", Kategorija="Animirani" }
            };

            return sviFilmovi.FindAll(f => f.Kategorija == kategorija);
        }
    }

    // Model film
    public class Film
    {
        public string Naziv { get; set; }
        public string Godina { get; set; }
        public string Slika { get; set; }
        public string Kategorija { get; set; }
        public string Trailer { get; internal set; }
        public double Ocjena { get; internal set; }
        public int Trajanje { get; internal set; }
        public string Opis { get; internal set; }
    }
}
