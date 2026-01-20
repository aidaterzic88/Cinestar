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
                new Film { Naziv="Crazy Rich Asians", Godina="2018", Slika="crazyrich.jpg" , 
                           Opis="Crazy Rich Asians je romantična komedija koja prati mladu profesoricu koja prvi put putuje u Singapur sa svojim momkom, gdje otkriva da njegova porodica pripada izuzetno bogatoj eliti. Film kroz humor i glamur istražuje teme ljubavi, porodičnih očekivanja, identiteta i kulturnih razlika.\r\n",                    
                           Trajanje=150, Ocjena=7.5, TrailerUrl=new Uri("https://youtu.be/ZQ-YX-5bAs0?si=R2rKYYeiFKJ5GDFl")},
                new Film { Naziv="La La Land", Godina="2016", Slika="lalaland.jpg" ,
                           Opis="La La Land je romantična muzička drama koja prati ambicioznu glumicu i talentovanog muzičara dok pokušavaju ostvariti svoje snove u Los Angelesu. Film istražuje balans između ljubavi i karijere, snova i realnosti, uz upečatljivu muziku, plesne scene i emotivnu atmosferu.\n",
                           Trajanje=130, Ocjena=9.5,  TrailerUrl=new Uri("https://youtu.be/0pdqf4P9MB8?si=tocIhDUopzNY8JVg")}
            };
        }

        private async void Film_Tapped(object sender, EventArgs e)
        {
           
            var frame = sender as Frame;
            if (frame?.BindingContext is Film odabraniFilm)
            {
                var detaljiStranica = new DetaljiFilma(odabraniFilm);
                await Navigation.PushAsync(detaljiStranica);
            }
        }
    }
}
