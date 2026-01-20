using Microsoft.Maui.Controls;

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
}
