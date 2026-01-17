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

        public ObservableCollection<Film> Najgledaniji { get; set; }
        public ObservableCollection<Film> FilmoviNaProgramu { get; set; }

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

            Najgledaniji = new ObservableCollection<Film>
            {
                new Film
                {
                    Naziv = "The Fast and the Furious",
                    Godina = "2001",
                    Slika = "fastfurious.jpg",
                    Trajanje = 150,
                    Ocjena = 8.2,
                    Opis = "Fast & Furious je akcijski filmski serijal koji prati svijet ilegalnih uličnih utrka, brzih automobila i opasnih misija. Film se fokusira na teme porodice, lojalnosti i adrenalinske akcije, prateći likove koji balansiraju između zakona i podzemlja dok testiraju granice brzine i povjerenja.\r\n",
                    TrailerUrl = new Uri("https://youtu.be/ZsJz2TJAPjw?si=OkMXCNM7Xgup5E1N")
                },
                new Film
                {
                    Naziv = "Formula 1",
                    Godina = "2023",
                    Slika = "film2.jpg",
                    Trajanje = 115,
                    Ocjena = 7.5,
                    Opis = "Formula 1 je uzbudljiv film koji donosi pogled iza kulisa najbržeg i najelitnijeg autosportskog takmičenja na svijetu. Kroz vrhunsku tehnologiju, rivalstva i lične priče vozača, film prikazuje borbu za slavu, savršen krug i titulu svjetskog prvaka.\r\n",
                    TrailerUrl = new Uri("https://youtu.be/69ffwl-8pCU?si=cHM_UrthLTFIx17U")
                },
                 new Film
                {
                    Naziv="Mad Max", Godina="2015", Slika="madmax.jpg" ,
                    Opis="Fury Road je postapokaliptični akcioni film smješten u pustinjski svijet gdje vlada haos i borba za opstanak. Priča prati usamljenog ratnika Maxa koji se udružuje s hrabrom Furiosom kako bi pobjegli od tiranskog vladara. Film se ističe neprekidnom akcijom, snažnim vizuelnim identitetom i temama slobode, preživljavanja i pobune protiv ugnjetavanja.\n",
                    Trajanje=150,Ocjena=6.5,TrailerUrl=new Uri("https://youtu.be/hEJnMQG9ev8?si=UqIryoGz6FmZ2eNd")
                }
            };

            FilmoviNaProgramu = new ObservableCollection<Film>
            {
                new Film { Slika="frozen.jpeg", Naziv="Frozen", Godina="2013", Trajanje=170, Ocjena=9.5, 
                    Opis="Frozen je animirani muzički film koji prati dvije sestre, Elsu i Annu, u kraljevstvu zahvaćenom vječnom zimom. Kroz avanturu, pjesme i emocije, film istražuje teme porodične ljubavi, hrabrosti i samoprihvatanja.\n",
                    TrailerUrl=new Uri("https://youtu.be/TbQm5doF_Uc?si=4FCcmbGUF7DmqaXb") },
                new Film { Naziv="John Wick", Godina="2014", Slika="john2.jpg", Trajanje=160, Ocjena=4.5,
                    Opis="John Wick je napeti akcioni film koji prati povučenog bivšeg plaćenog ubicu koji se, nakon ličnog gubitka, vraća u svijet kriminala. Film je poznat po stiliziranim akcijskim scenama, preciznoj koreografiji borbi i mračnoj atmosferi. Radnja istražuje teme osvete, časti i posljedica nasilja, uz jedinstveno izgrađen podzemni svijet profesionalnih ubica.\n",
                    TrailerUrl=new Uri("https://youtu.be/C0BMx-qxsP4?si=6Yb6rG3gbN45U1YL") },
                new Film {Naziv="Crazy Rich Asians", Godina="2018", Slika="crazyrich.jpg" ,
                           Opis="Crazy Rich Asians je romantična komedija koja prati mladu profesoricu koja prvi put putuje u Singapur sa svojim momkom, gdje otkriva da njegova porodica pripada izuzetno bogatoj eliti. Film kroz humor i glamur istražuje teme ljubavi, porodičnih očekivanja, identiteta i kulturnih razlika.\r\n",
                           Trajanje=150, Ocjena=7.5, TrailerUrl=new Uri("https://youtu.be/ZQ-YX-5bAs0?si=R2rKYYeiFKJ5GDFl")},
                new Film { Naziv="La La Land", Godina="2016", Slika="lalaland.jpg" ,
                           Opis="La La Land je romantična muzička drama koja prati ambicioznu glumicu i talentovanog muzičara dok pokušavaju ostvariti svoje snove u Los Angelesu. Film istražuje balans između ljubavi i karijere, snova i realnosti, uz upečatljivu muziku, plesne scene i emotivnu atmosferu.\n",
                           Trajanje=130, Ocjena=9.5,  TrailerUrl=new Uri("https://youtu.be/0pdqf4P9MB8?si=tocIhDUopzNY8JVg")},
                new Film {   Naziv="Mad Max", Godina="2015", Slika="madmax2.jpg" ,
                    Opis="Fury Road je postapokaliptični akcioni film smješten u pustinjski svijet gdje vlada haos i borba za opstanak. Priča prati usamljenog ratnika Maxa koji se udružuje s hrabrom Furiosom kako bi pobjegli od tiranskog vladara. Film se ističe neprekidnom akcijom, snažnim vizuelnim identitetom i temama slobode, preživljavanja i pobune protiv ugnjetavanja.\n",
                    Trajanje=150,Ocjena=6.5,TrailerUrl=new Uri("https://youtu.be/hEJnMQG9ev8?si=UqIryoGz6FmZ2eNd")},
                new Film {  Naziv="Friends: The Movie", Godina="2024", Slika="friends.jpg" ,
                    Opis="Friends: The Movie okuplja omiljenu šestorku prijatelja u novoj, proširenoj priči koja donosi sve ono po čemu je serija postala kultna. Film prati njihove živote dok se suočavaju s novim izazovima u ljubavi, poslu i prijateljstvu, uz prepoznatljiv humor, emotivne trenutke i snažnu povezanost među likovima. Fokus je na prijateljstvu, zajedništvu i životnim promjenama koje dolaze s vremenom.\n",
                    Trajanje=180, Ocjena=8.5, TrailerUrl=new Uri("https://youtu.be/Zg2LCD5QOJs?si=OQYxr575KlYcUt2v") }
            };
        }

      
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
