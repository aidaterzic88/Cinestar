using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinestar2.Models;
using Microsoft.Maui.Controls.Maps;

namespace Cinestar2.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Gradovi { get; set; }

        private string izabraniGrad;
        public string IzabraniGrad
        {
            get => izabraniGrad;
            set
            {
                if (izabraniGrad != value)
                {
                    izabraniGrad = value;
                    OnPropertyChanged(nameof(IzabraniGrad));
                }
            }
        }

        public ObservableCollection<Film> Traileri { get; set; }
        public ObservableCollection<Film> FilmoviNaProgramu { get; set; }

        // Dictionary za gradove i njihove koordinate
        public Dictionary<string, Location> GradKoordinate { get; set; }

        public MainPageViewModel()
        {
            Gradovi = new ObservableCollection<string>
            {
                "Zenica", "Sarajevo", "Mostar", "Tuzla", "Banja Luka"
            };

            GradKoordinate = new Dictionary<string, Location>
            {
                { "Zenica", new Location(44.2037, 17.9096) },
                { "Sarajevo", new Location(43.8563, 18.4131) },
                { "Mostar", new Location(43.3438, 17.8078) },
                { "Tuzla", new Location(44.5383, 18.6679) },
                { "Banja Luka", new Location(44.7722, 17.1910) }
            };

            Traileri = new ObservableCollection<Film>
            {
                new Film
                {
                    Naziv = "The Fast and the Furious",
                    Godina = "2001",
                    Slika = "fastfurious.jpg",
                    Trajanje = 150,
                    Ocjena = 8.2,
                    Opis = "Akcijska avantura u svijetu uličnih utrka.",
                    Trailer = "https://youtube.com/..."
                },
                new Film
                {
                    Naziv = "Formula 1",
                    Godina = "2023",
                    Slika = "film2.jpg",
                    Trajanje = 115,
                    Ocjena = 7.5,
                    Opis = "Dokumentarni film o Formuli 1.",
                    Trailer = "https://youtube.com/..."
                },
                 new Film
                {
                    Naziv = "Crazy Rich Asians",
                    Godina = "2001",
                    Slika = "crazyrich.jpg",
                    Trajanje = 130,
                    Ocjena = 8.2,
                    Opis = "Akcijska avantura u svijetu uličnih utrka.",
                    Trailer = "https://youtube.com/..."
                }
            };

            FilmoviNaProgramu = new ObservableCollection<Film>
            {
                new Film { Slika="film1spuzva.jpg", Naziv="Spužva Bob", Godina="2020", Trajanje=100, Ocjena=7.0, Opis="Animirani film", Trailer="" },
                new Film { Slika="film2.jpg", Naziv="Formula 1", Godina="2023", Trajanje=115, Ocjena=7.5, Opis="Dokumentarni film", Trailer="" },
                new Film { Slika="film3anakonda.jpg", Naziv="Anakonda", Godina="1997", Trajanje=110, Ocjena=6.8, Opis="Horor film", Trailer="" },
                new Film { Slika="film4elio.jpg", Naziv="Elio", Godina="2025", Trajanje=95, Ocjena=7.2, Opis="Animacija", Trailer="" },
                new Film { Slika="film5trenutak.jpg", Naziv="Trenutak", Godina="2022", Trajanje=120, Ocjena=7.9, Opis="Drama", Trailer="" },
                new Film { Slika="film6.jpg", Naziv="Nešto", Godina="2021", Trajanje=130, Ocjena=6.5, Opis="Akcija", Trailer="" }
            };
        }

        // INotifyPropertyChanged implementacija
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
