using Microsoft.Maui.Controls;
using System.Collections.Generic;
using Cinestar2.Models;
using Cinestar2.Pages;

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
                new Film { Naziv="Toy Story", Godina="1995", Slika="toystory.jpg" , TrailerUrl=new Uri("https://youtu.be/v-PjgYDrg70?si=Nidq3V8H5pa4-vrS")},
                new Film { Naziv="Frozen", Godina="2013", Slika="frozen.jpg", TrailerUrl=new Uri("https://youtu.be/TbQm5doF_Uc?si=4FCcmbGUF7DmqaXb") }
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
