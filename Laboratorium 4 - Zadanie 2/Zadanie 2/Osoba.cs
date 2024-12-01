using System;

namespace Laboratorium4
{
    public class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string pesel;

        public Osoba(string imie, string nazwisko, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }

        public void UstawImie(string imie)
        {
            this.imie = imie;
        }

        public void UstawNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        public void UstawPesel(string pesel)
        {
            this.pesel = pesel;
        }

        public int PobierzWiek()
        {
            int rok = int.Parse(pesel.Substring(0, 2));
            int miesiac = int.Parse(pesel.Substring(2, 2));
            int dzien = int.Parse(pesel.Substring(4, 2));
            rok += (miesiac > 20) ? 2000 : 1900;
            DateTime dataUrodzenia = new DateTime(rok, miesiac % 20, dzien);
            int wiek = DateTime.Now.Year - dataUrodzenia.Year;
            if (DateTime.Now < dataUrodzenia.AddYears(wiek)) wiek--;
            return wiek;
        }

        public string PobierzPlec()
        {
            return (int.Parse(pesel[9].ToString()) % 2 == 0) ? "Kobieta" : "Mężczyzna";
        }

        public virtual string PobierzInformacjeOEdukacji()
        {
            return "Brak informacji o edukacji.";
        }

        public virtual bool CzyMozeSamWrocicDoDomu()
        {
            return false;
        }

        public string PobierzPelneImieNazwisko()
        {
            return $"{imie} {nazwisko}";
        }
    }
}
