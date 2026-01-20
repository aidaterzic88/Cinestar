using Cinestar2.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Cinestar2;

public class UlazniceViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string film = string.Empty;
    private int kolicina = 0;
    private decimal iznos = 0;
    private Kartica? odabranaKartica;

    public string Film
    {
        get => film;
        set { film = value; OnPropertyChanged(nameof(Film)); }
    }

    public int Kolicina
    {
        get => kolicina;
        set { kolicina = value; OnPropertyChanged(nameof(Kolicina)); }
    }

    public decimal Iznos
    {
        get => iznos;
        set { iznos = value; OnPropertyChanged(nameof(Iznos)); }
    }

    public Kartica? OdabranaKartica
    {
        get => odabranaKartica;
        set { odabranaKartica = value; OnPropertyChanged(nameof(OdabranaKartica)); }
    }

    public Kartica? SavedCard => AppData.ActiveCard;

    public bool HasCard => SavedCard != null;

    public ICommand QuickPayCommand => new Command(async () =>
    {
        await Application.Current.MainPage.DisplayAlert(
            "Plaćanje",
            "Plaćanje izvršeno sa sačuvanom karticom.",
            "OK");
    });

    public ObservableCollection<Kartica> Kartice { get; set; } = new();

    private void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
