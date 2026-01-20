namespace Cinestar2; 
public class Kartica { 
    public string ImeNaKartici { get; set; } 
    public string BrojKartice { get; set; } 
    public string CVV { get; set; } 
    public string DatumIsteka { get; set; }
    public string MaskiraniBroj =>
    BrojKartice.Length >= 4
        ? $"**** **** **** {BrojKartice[^4..]}"
        : "****";
}