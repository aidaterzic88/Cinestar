using Microsoft.Maui.Controls;

namespace Cinestar2.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // LOGIN → HOME + TAB BAR
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // TODO: ovdje kasnije ide prava validacija (UserStore / ViewModel)
            // npr: if (loginValidan)

            await Shell.Current.GoToAsync("//main");
        }

        // NEMAM RAČUN → REGISTER
        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//register");
        }
    }
}
