using Microsoft.Maui.Controls;
using Cinestar2.Models;

namespace Cinestar2.Pages;

public partial class Placanje : ContentPage
{
    public string Film { get; set; } = string.Empty;
    public int Kolicina { get; set; }
    public decimal Iznos { get; set; }

    public Placanje()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private async void SpremiIPlati_Clicked(object sender, EventArgs e)
    {
        var ulaznica = new KupljenaUlaznica
        {
            Film = Film,
            Kolicina = Kolicina,
            Iznos = Iznos,
            KarticaMaskirana = "**** **** **** 1234" 
        };

        AppData.KupljeneUlaznice.Add(ulaznica);

        await DisplayAlert("Uspjeh", "Plaćanje uspješno!", "OK");

        await Shell.Current.GoToAsync("//main/Ulaznice");
    }
}
