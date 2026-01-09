using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using Cinestar2.Models;

namespace Cinestar2;

public partial class Ulaznice : ContentPage
{
    public ObservableCollection<KupljenaUlaznica> KupljeneUlaznice { get; set; }

    public Ulaznice()
    {
        InitializeComponent();

        KupljeneUlaznice =
            new ObservableCollection<KupljenaUlaznica>(AppData.KupljeneUlaznice);

        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        KupljeneUlaznice.Clear();
        foreach (var u in AppData.KupljeneUlaznice)
            KupljeneUlaznice.Add(u);
    }

    // 🗑️ BRISANJE ULAZNICE
    private async void ObrisiUlaznicu_Clicked(object sender, EventArgs e)
    {
        if (sender is ImageButton button &&
            button.CommandParameter is KupljenaUlaznica ulaznica)
        {
            bool potvrda = await DisplayAlert(
                "Potvrda",
                $"Želite li ukloniti ulaznicu za film:\n{ulaznica.Film}?",
                "Da",
                "Ne");

            if (!potvrda)
                return;

            // uklanjanje iz globalne liste
            AppData.KupljeneUlaznice.Remove(ulaznica);

            // uklanjanje iz UI kolekcije
            KupljeneUlaznice.Remove(ulaznica);
        }
    }
}
