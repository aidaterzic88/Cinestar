using System.Collections.Generic;
using Cinestar2.Models;

namespace Cinestar2
{
    public static class AppData
    {
        public static List<KupljenaUlaznica> KupljeneUlaznice { get; set; } = new List<KupljenaUlaznica>();
        public static List<Kartica> SpremljeneKartice { get; set; } = new List<Kartica>();
    }
}
