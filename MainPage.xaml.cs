using Cinestar2.ViewModels;
using Cinestar2.Pages;

namespace Cinestar2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            var image = sender as Image;
            var film = (Film)((TapGestureRecognizer)image.GestureRecognizers[0]).CommandParameter;

            if (film != null)
            {
            
                await Navigation.PushAsync(new DetaljiFilma(film));
            }
        }
    }
}
