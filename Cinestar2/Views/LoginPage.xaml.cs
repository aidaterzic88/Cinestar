using Microsoft.Maui.Controls;

namespace Cinestar2.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            // Navigacija na RegisterPage
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
