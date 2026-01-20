using Cinestar2.ViewModels;

namespace Cinestar2.Pages
{
    public partial class Placanje : ContentPage
    {
        public Placanje()
        {
            InitializeComponent();
            BindingContext = new UlazniceViewModel();
        }

        private async void Plati_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert(
                "Uspješno plaćanje",
                "Vaša kupovina je uspješno izvršena!",
                "OK");

            await Navigation.PopToRootAsync();
        }
    }
}
