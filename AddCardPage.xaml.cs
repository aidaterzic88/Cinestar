using Microsoft.Maui.Controls;
using Cinestar2.Models;

namespace Cinestar2;

[QueryProperty(nameof(Film), "film")]
[QueryProperty(nameof(Kolicina), "kolicina")]
[QueryProperty(nameof(Iznos), "iznos")]
public partial class AddCardPage : ContentPage
{
    public AddCardViewModel ViewModel { get; set; }

    public AddCardPage()
    {
        InitializeComponent();
        ViewModel = new AddCardViewModel();
        BindingContext = ViewModel;
    }

    public string Film
    {
        set => ViewModel.Film = value;
    }

    public int Kolicina
    {
        set => ViewModel.Kolicina = value;
    }

    public decimal Iznos
    {
        set => ViewModel.Iznos = value;
    }

    private async void SpremiIPlati_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(ViewModel.ImeNaKartici) ||
            string.IsNullOrWhiteSpace(ViewModel.BrojKartice) ||
            string.IsNullOrWhiteSpace(ViewModel.CVV) ||
            string.IsNullOrWhiteSpace(ViewModel.DatumIsteka))
        {
            await DisplayAlert("Greška", "Popunite sve podatke.", "OK");
            return;
        }

        var ulaznica = new KupljenaUlaznica
        {
            Film = ViewModel.Film,
            Kolicina = ViewModel.Kolicina,
            Iznos = ViewModel.Iznos,
            KarticaMaskirana = $"**** **** **** {ViewModel.BrojKartice[^4..]}"
        };

        AppData.KupljeneUlaznice.Add(ulaznica);

        await DisplayAlert("Uspjeh", "Plaćanje uspješno 🎉", "OK");

        await Shell.Current.GoToAsync("//main/Ulaznice");
    }
}
