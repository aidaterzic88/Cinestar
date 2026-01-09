using Microsoft.Maui.Controls;

namespace Cinestar2.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        // REGISTRACIJA ZAVRŠENA → POVRATAK NA LOGIN
        private async void OnRegisterCompleted(object sender, EventArgs e)
        {
            // TODO: ovdje kasnije ide snimanje korisnika (UserStore)

            await Shell.Current.GoToAsync("//login");
        }
    }
}
