using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Cinestar2.Models;

namespace Cinestar2.ViewModels
{
    public class ProfilViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Korisnik _korisnik;
        public Korisnik Korisnik
        {
            get => _korisnik;
            set
            {
                _korisnik = value;
                OnPropertyChanged();
            }
        }

        public ICommand OdjavaCommand { get; }

        public ProfilViewModel()
        {
            Korisnik = new Korisnik
            {
                Email = "email@primjer.com",
                Spol = "Muško",
                ImePrezime = "Ime Prezime",
                DatumRodjenja = "01.01.2000",
                Adresa = "Ulica 12",
                Grad = "Sarajevo",
                Drzava = "BiH"
            };

            OdjavaCommand = new Command(OdjaviSe);
        }

        private async void OdjaviSe()
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
