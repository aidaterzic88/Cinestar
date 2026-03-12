# Cinestar

Cinestar je moderna mobilna aplikacija razvijena kao dio predmeta "Razvoj mobilnih aplikacija" na Politehničkom fakultetu Univerziteta u Zenici. Aplikacija omogućava korisnicima pregled filmskog repertoara, kupovinu kino ulaznica i evidenciju kupljenih karata, sve na jednom mjestu.

Projekt je realizovan korištenjem .NET MAUI frameworka i MVVM arhitekture, čime je osigurano jasno razdvajanje korisničkog interfejsa i poslovne logike, te omogućena laka nadogradnja i održavanje sistema.

Ključne funkcionalnosti
Korisnički sistem
Registracija - Kreiranje korisničkog naloga sa ličnim podacima
Prijava - Siguran pristup aplikaciji
Profil korisnika - Pregled i upravljanje ličnim informacijama

Filmski sadržaj
Početna stranica - Pregled najgledanijih i trenutno dostupnih filmova
Kategorije filmova - Filtriranje po žanrovima (akcija, komedija, animirani, romantika)
Detalji filma - Prikaz opisa, trajanja, cijene i trailera

Kupovina i upravljanje
Kupovina ulaznica - Odabir broja karata sa automatskim obračunom cijene
Spremanje kartica - Čuvanje podataka za brzo plaćanje
Evidencija ulaznica - Pregled i upravljanje kupljenim kartama
Uklanjanje ulaznica - Mogućnost brisanja pojedinačnih karata

Dodatne mogućnosti
Integracija sa Google mapama - Jednostavno lociranje kina
Prikaz trailera - WebView integracija za pregled video materijala
Odabir grada - Personalizacija prikaza prema lokaciji

Arhitektura
Aplikacija je razvijena koristeći MVVM (Model-View-ViewModel) arhitektonski obrazac:
📁 Cinestar/
├── 📂 Models/          # Podatkovni modeli (Film, Korisnik, KupljenaUlaznica)
├── 📂 ViewModels/      # Poslovna logika i data binding
├── 📂 Views/           # Korisnički interfejs (XAML stranice)
├── 📂 Services/        # Servisi (AuthService, itd.)
└── 📂 Assets/          # Slike i resursi

Tehnologije i alati
.NET MAUI - Multiplatformski framework za razvoj mobilnih aplikacija
C# - Programski jezik za poslovnu logiku
XAML - Označni jezik za korisnički interfejs
Data Binding - Povezivanje UI elemenata sa ViewModel-ima
ObservableCollection - Dinamičko upravljanje kolekcijama podataka
