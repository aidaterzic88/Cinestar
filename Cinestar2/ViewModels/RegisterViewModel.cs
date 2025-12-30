using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Cinestar2.Models;

namespace Cinestar2.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
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

        private string confirmPassword;
        public string ConfirmPassword
        {
            get => confirmPassword;
            set { confirmPassword = value; OnPropertyChanged(nameof(ConfirmPassword)); }
        }

        public ICommand RegisterCommand { get; }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnRegister()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please fill all fields", "OK");
                return;
            }

            if (Password != ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Passwords do not match", "OK");
                return;
            }

            if (UserStore.Users.Exists(u => u.Username == Username))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Username already exists", "OK");
                return;
            }

            // Dodajemo novog korisnika u memoriju
            UserStore.Users.Add(new User { Username = Username, Password = Password });

            await Application.Current.MainPage.DisplayAlert("Uspješno", "Korisnik registrovan", "OK");

            // Navigacija nazad na LoginPage
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

