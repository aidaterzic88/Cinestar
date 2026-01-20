using Cinestar2.Services;
using Cinestar2.ViewModels;
using Microsoft.Maui.Controls;

namespace Cinestar2
{
    public partial class Korisnikovprofil : ContentPage
    {
        public Korisnikovprofil()
        {
            InitializeComponent();
            BindingContext = new ProfilViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (AuthService.TrenutniKorisnik == null)
            {
                await Shell.Current.GoToAsync("//login");
            }
        }
    }
}
