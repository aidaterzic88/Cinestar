using Cinestar2.ViewModels;
namespace Cinestar2; 
public partial class Korisnikovprofil : ContentPage
{ 
    public Korisnikovprofil() {
        InitializeComponent(); 
        BindingContext = new ProfilViewModel();
    }
}