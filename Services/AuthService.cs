using Cinestar2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinestar2.ViewModels;

namespace Cinestar2.Services
{
    public static class AuthService
    {
        public static Korisnik TrenutniKorisnik { get; set; }

        public static void Logout()
        {
            TrenutniKorisnik = null;
        }
    }
}
