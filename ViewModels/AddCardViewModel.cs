using System.ComponentModel;

namespace Cinestar2
{
    public class AddCardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string imeNaKartici = string.Empty;
        private string brojKartice = string.Empty;
        private string cvv = string.Empty;
        private string datumIsteka = string.Empty;
        private string film = string.Empty;
        private int kolicina = 0;
        private decimal iznos = 0;

        public string ImeNaKartici
        {
            get => imeNaKartici;
            set { imeNaKartici = value; OnPropertyChanged(nameof(ImeNaKartici)); }
        }

        public string BrojKartice
        {
            get => brojKartice;
            set { brojKartice = value; OnPropertyChanged(nameof(BrojKartice)); }
        }

        public string CVV
        {
            get => cvv;
            set { cvv = value; OnPropertyChanged(nameof(CVV)); }
        }

        public string DatumIsteka
        {
            get => datumIsteka;
            set { datumIsteka = value; OnPropertyChanged(nameof(DatumIsteka)); }
        }

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

        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}