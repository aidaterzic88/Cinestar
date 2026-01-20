using System.ComponentModel;
using System.Windows.Input;
using Cinestar2.Models;

namespace Cinestar2
{
    public class AddCardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private Kartica? savedCard;
        public Kartica? SavedCard
        {
            get => savedCard;
            set
            {
                savedCard = value;
                OnPropertyChanged(nameof(SavedCard));
                OnPropertyChanged(nameof(HasCard)); 
            }
        }

        public bool HasCard => SavedCard != null;

        public string ImeNaKartici { get; set; } = string.Empty;
        public string BrojKartice { get; set; } = string.Empty;
        public string CVV { get; set; } = string.Empty;
        public string DatumIsteka { get; set; } = string.Empty;


        public string Film { get; set; } = string.Empty;
        public int Kolicina { get; set; }
        public decimal Iznos { get; set; }

     
        public ICommand SaveCardCommand => new Command(() =>
        {
            var kartica = new Kartica
            {
                ImeNaKartici = ImeNaKartici,
                BrojKartice = BrojKartice,
                CVV = CVV,
                DatumIsteka = DatumIsteka
            };

            SavedCard = kartica;

            if (!AppData.SpremljeneKartice.Contains(kartica))
                AppData.SpremljeneKartice.Add(kartica);

            AppData.ActiveCard = kartica;
        });

        public ICommand QuickPayCommand => new Command(async () =>
        {
            if (SavedCard == null)
                return;

            var ulaznica = new KupljenaUlaznica
            {
                Film = Film,
                Kolicina = Kolicina,
                Iznos = Iznos,
                KarticaMaskirana = SavedCard.MaskiraniBroj
            };

            AppData.KupljeneUlaznice.Add(ulaznica);

            await Application.Current.MainPage.DisplayAlert(
                "Plaćanje",
                "Plaćanje izvršeno sa sačuvanom karticom.",
                "OK");

            await Shell.Current.GoToAsync("//main/Ulaznice");
        });

        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
