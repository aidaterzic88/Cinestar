using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinestar2.Models
{
    public class Film
    {
        public required string Naziv { get; set; }
        public required string Godina { get; set; }
        public required string Slika { get; set; }
        public required int Trajanje { get; set; }
        public required double Ocjena { get; set; }
        public required string Opis { get; set; }
        public required string Trailer { get; set; }
    }
}
