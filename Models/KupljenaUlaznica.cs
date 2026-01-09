using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinestar2.Models
{
    public class KupljenaUlaznica
    {
        public string Film { get; set; }
        public int Kolicina { get; set; }
        public decimal Iznos { get; set; }
        public string KarticaMaskirana { get; set; }
    }
}
