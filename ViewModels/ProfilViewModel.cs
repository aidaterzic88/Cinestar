using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Cinestar2.Models;
using Cinestar2.Services;
using Microsoft.Maui.ApplicationModel; // za Map
using Microsoft.Maui.Devices.Sensors; // za Location
using System.Threading.Tasks;

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

        // Komande
        public ICommand OdjavaCommand { get; }
        public ICommand OtvoriMapuCommand { get; }

        public ProfilViewModel()
        {
            Korisnik = AuthService.TrenutniKorisnik;

            OdjavaCommand = new Command(async () => await OdjaviSe());
            OtvoriMapuCommand = new Command(async () => await OtvoriMapu());
        }

        private async Task OdjaviSe()
        {
            AuthService.Logout();
            await Shell.Current.GoToAsync("//login");
        }

        private async Task OtvoriMapu()
        {
            // Lokacija: Cinestar Sarajevo
            var location = new Location(43.8563, 18.4131);

            var options = new MapLaunchOptions
            {
                Name = "Cinestar Sarajevo",
                NavigationMode = NavigationMode.None
            };

            try
            {
                await Map.Default.OpenAsync(location, options);
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Greška",
                    "Nije moguće otvoriti mapu.",
                    "OK");
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
