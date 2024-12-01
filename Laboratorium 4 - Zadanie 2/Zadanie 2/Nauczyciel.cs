using System;
using System.Collections.Generic;

namespace Laboratorium4
{
    public class Nauczyciel : Osoba
    {
        private string tytulNaukowy;
        private List<Uczen> uczniowieKlasy;

        public Nauczyciel(string imie, string nazwisko, string pesel, string tytulNaukowy) : base(imie, nazwisko, pesel)
        {
            this.tytulNaukowy = tytulNaukowy;
            this.uczniowieKlasy = new List<Uczen>();
        }

        public void DodajUcznia(Uczen uczen)
        {
            uczniowieKlasy.Add(uczen);
        }

        public List<Uczen> KtorzyUcziowieMogaWrocicSamodzielnie()
        {
            var uczniowieSamodzielni = new List<Uczen>();
            foreach (var uczen in uczniowieKlasy)
            {
                if (uczen.CzyMozeSamWrocicDoDomu())
                {
                    uczniowieSamodzielni.Add(uczen);
                }
            }
            return uczniowieSamodzielni;
        }

        public void PodsumowanieKlasy(DateTime data)
        {
            Console.WriteLine($"Dnia: {data.ToShortDateString()}");
            Console.WriteLine($"Nauczyciel: {tytulNaukowy} {PobierzPelneImieNazwisko()}");
            Console.WriteLine("Lista studentów:");

            int lp = 1;
            foreach (var uczen in uczniowieKlasy)
            {
                string pelneImieNazwisko = uczen.PobierzPelneImieNazwisko();
                string plec = uczen.PobierzPlec();
                string mozeSam = uczen.CzyMozeSamWrocicDoDomu() ? "Może wrócić sam" : "Nie może wrócić sam";
                Console.WriteLine($"{lp}. {pelneImieNazwisko} - {plec} - {mozeSam}");
                lp++;
            }
        }
    }
}
