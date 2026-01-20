using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Cinestar2.Models;
using Cinestar2.Services;

namespace Cinestar2.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string ImePrezime { get; set; }
        public string Grad { get; set; }
        public DateTime DatumRodjenja { get; set; } = DateTime.Today;

        public ICommand RegisterCommand { get; }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
        }

        private async Task Register()
        {
            if (string.IsNullOrWhiteSpace(Username) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(ImePrezime) ||
                string.IsNullOrWhiteSpace(Grad))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Greška", "Sva polja su obavezna", "OK");
                return;
            }

            if (Password != ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Greška", "Lozinke se ne poklapaju", "OK");
                return;
            }

            if (UserStore.Users.Any(u => u.Username == Username))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Greška", "Korisnik već postoji", "OK");
                return;
            }

            var noviKorisnik = new Korisnik
            {
                Username = Username,
                Password = Password,
                ImePrezime = ImePrezime,
                Grad = Grad,
                Drzava = "BiH",
                DatumRodjenja = DatumRodjenja,
                Email = $"{Username}@cinestar.ba"
            };

            UserStore.Users.Add(noviKorisnik);
            AuthService.TrenutniKorisnik = noviKorisnik;

            await Application.Current.MainPage.DisplayAlert(
                "Uspješno", "Registracija uspješna", "OK");

            await Shell.Current.GoToAsync("//login");
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
