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
                new Film { Naziv="John Wick", Godina="2014", Slika="john2.jpg", Trajanje=160, Ocjena=4.5, 
                    Opis="John Wick je napeti akcioni film koji prati povučenog bivšeg plaćenog ubicu koji se, nakon ličnog gubitka, vraća u svijet kriminala. Film je poznat po stiliziranim akcijskim scenama, preciznoj koreografiji borbi i mračnoj atmosferi. Radnja istražuje teme osvete, časti i posljedica nasilja, uz jedinstveno izgrađen podzemni svijet profesionalnih ubica.\n", 
                    TrailerUrl=new Uri("https://youtu.be/C0BMx-qxsP4?si=6Yb6rG3gbN45U1YL") },
                new Film { Naziv="Mad Max", Godina="2015", Slika="madmax2.jpg" ,
                    Opis="Fury Road je postapokaliptični akcioni film smješten u pustinjski svijet gdje vlada haos i borba za opstanak. Priča prati usamljenog ratnika Maxa koji se udružuje s hrabrom Furiosom kako bi pobjegli od tiranskog vladara. Film se ističe neprekidnom akcijom, snažnim vizuelnim identitetom i temama slobode, preživljavanja i pobune protiv ugnjetavanja.\n", 
                    Trajanje=150,Ocjena=6.5,TrailerUrl=new Uri("https://youtu.be/hEJnMQG9ev8?si=UqIryoGz6FmZ2eNd")},
                 new Film { Naziv = "The Fast and the Furious", Godina = "2001",
                    Slika = "fastfurious.jpg",
                    Trajanje = 150,
                    Ocjena = 8.2,
                    Opis = "Fast & Furious je akcijski filmski serijal koji prati svijet ilegalnih uličnih utrka, brzih automobila i opasnih misija. Film se fokusira na teme porodice, lojalnosti i adrenalinske akcije, prateći likove koji balansiraju između zakona i podzemlja dok testiraju granice brzine i povjerenja.",                  
                 TrailerUrl=new Uri("https://youtu.be/ZsJz2TJAPjw?si=OkMXCNM7Xgup5E1N")},
                 new Film {Naziv = "Formula 1",
                    Godina = "2023",
                    Slika = "film2.jpg",
                    Trajanje = 115,
                    Ocjena = 7.5,
                    Opis = "Formula 1 je uzbudljiv film koji donosi pogled iza kulisa najbržeg i najelitnijeg autosportskog takmičenja na svijetu. Kroz vrhunsku tehnologiju, rivalstva i lične priče vozača, film prikazuje borbu za slavu, savršen krug i titulu svjetskog prvaka.\r\n",
                    TrailerUrl = new Uri("https://youtu.be/69ffwl-8pCU?si=cHM_UrthLTFIx17U")}
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
