using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Cinestar2.Models;

namespace Cinestar2.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string username;
        public string Username
        {
            get => username;
            set { username = value; OnPropertyChanged(nameof(Username)); }
        }

        private string password;
        public string Password
        {
            get => password;
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
        }

        private async void OnLogin()
        {
            var user = UserStore.Users.Find(u => u.Username == Username && u.Password == Password);
            if (user != null)
            {
                await Shell.Current.GoToAsync("//main");

                // Ovdje možeš navigirati na glavnu stranicu
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešno korisničko ime ili lozinka", "OK");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

