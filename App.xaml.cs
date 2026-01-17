using Cinestar2.Pages;

namespace Cinestar2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            Routing.RegisterRoute(nameof(DetaljiFilma), typeof(DetaljiFilma));


          
            Dispatcher.Dispatch(async () =>
            {
                await Shell.Current.GoToAsync("//login");
            });
        }
    }
}
