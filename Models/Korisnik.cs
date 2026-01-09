using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinestar2.Models
{
    public class Korisnik
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Spol { get; set; }
        public string DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public string ImePrezime { get; set; }
    }
}
