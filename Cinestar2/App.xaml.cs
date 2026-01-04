namespace Cinestar2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            // Sačekaj da se Shell inicijalizira
            Dispatcher.Dispatch(async () =>
            {
                await Shell.Current.GoToAsync("//login");
            });
        }
    }
}
