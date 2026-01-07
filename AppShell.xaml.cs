using Cinestar2.Views;
using Cinestar2.Pages;

namespace Cinestar2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // RUTE VAN TAB BAR-a
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("register", typeof(RegisterPage));
            Routing.RegisterRoute("main", typeof(MainPage));
         
        }
    }
}