using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinestar2.Models
{
    public class Film
    {
        public string Naziv { get; set; }
        public string Godina { get; set; }
        public string Slika { get; set; }
        public int Trajanje { get; set; }
        public double Ocjena { get; set; }
        public string Opis { get; set; }
        public string Trailer { get; set; }
    }
}
