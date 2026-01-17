using Microsoft.Maui.Controls;

namespace Cinestar2.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

      
        private async void OnRegisterCompleted(object sender, EventArgs e)
        {
          await Shell.Current.GoToAsync("//login");
        }
    }
}
