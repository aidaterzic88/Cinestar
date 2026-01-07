using Microsoft.Maui.Controls;

namespace Cinestar2
{
    public partial class Kategorije : ContentPage
    {
        public Kategorije()
        {
            InitializeComponent();
        }

        private async void Akcija_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Akcija());
        }

        private async void Komedija_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Komedija());
        }

        private async void Romantika_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Romantika());
        }

        private async void Animirani_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Animirani());
        }
    }
}
