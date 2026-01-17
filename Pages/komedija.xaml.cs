using Microsoft.Maui.Controls;
using System.Collections.Generic;
using Cinestar2.Models;
using Cinestar2.Pages;   

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
                new Film { Naziv="The Hangover", Godina="2009", Slika="hangover2.jpg" ,
                Opis="The Hangover je popularna komedija koja prati grupu prijatelja čija se momačka večer u Las Vegasu pretvara u potpuni haos. Nakon burne noći, bude se bez sjećanja na događaje od prethodne večeri i shvataju da je mladoženja nestao. Film je pun neočekivanih situacija, humora i prijateljskih nesporazuma, a fokusiran je na potragu za istinom i snalaženje u apsurdnim okolnostima.\n",
                    Trajanje=120, Ocjena=7.5, TrailerUrl=new Uri("https://youtu.be/TZc39afdeXU?si=Lwi1t9GPtK9L1y1Y") },
                new Film { Naziv="Friends: The Movie", Godina="2024", Slika="friends.jpg" ,
                    Opis="Friends: The Movie okuplja omiljenu šestorku prijatelja u novoj, proširenoj priči koja donosi sve ono po čemu je serija postala kultna. Film prati njihove živote dok se suočavaju s novim izazovima u ljubavi, poslu i prijateljstvu, uz prepoznatljiv humor, emotivne trenutke i snažnu povezanost među likovima. Fokus je na prijateljstvu, zajedništvu i životnim promjenama koje dolaze s vremenom.\n",
                    Trajanje=180, Ocjena=8.5, TrailerUrl=new Uri("https://youtu.be/Zg2LCD5QOJs?si=OQYxr575KlYcUt2v") }
            };
        }

      
        private async void Film_Tapped(object sender, EventArgs e)
        {
            var frame = sender as Frame;

            if (frame?.BindingContext is Film film)
            {
                
                await Navigation.PushAsync(new DetaljiFilma(film));
            }
        }
    }
}
