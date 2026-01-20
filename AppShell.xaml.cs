using Cinestar2.Views;
using Cinestar2.Pages;

namespace Cinestar2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();


            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("register", typeof(RegisterPage));
            Routing.RegisterRoute("main", typeof(MainPage));
            Routing.RegisterRoute(nameof(Ulaznice), typeof(Ulaznice));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(Ulaznice), typeof(Ulaznice));
            Routing.RegisterRoute(nameof(AddCardPage), typeof(AddCardPage));
        }
           
       


    }
}
    
