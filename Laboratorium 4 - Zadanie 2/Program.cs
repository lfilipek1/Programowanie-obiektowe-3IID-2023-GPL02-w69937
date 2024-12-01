using System;
using System.Collections.Generic;

namespace Laboratorium_4___Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nauczyciel = new Nauczyciel("Anna", "Kowalska", "76010112345", "Magister");

            var uczen1 = new Uczen("Jan", "Nowak", "10010112345", "Szkoła Podstawowa", true);
            var uczen2 = new Uczen("Maria", "Wiśniewska", "11040156789", "Szkoła Podstawowa", false);
            var uczen3 = new Uczen("Krzysztof", "Zieliński", "05050178912", "Szkoła Podstawowa", true);

            nauczyciel.DodajUcznia(uczen1);
            nauczyciel.DodajUcznia(uczen2);
            nauczyciel.DodajUcznia(uczen3);

            nauczyciel.PodsumowanieKlasy(DateTime.Now);

            var samodzielni = nauczyciel.KtorzyUcziowieMogaWrocicSamodzielnie();
            Console.WriteLine("\nUczniowie, którzy mogą wracać samodzielnie:");
            foreach (var uczen in samodzielni)
            {
                Console.WriteLine($"{uczen.PobierzPelneImieNazwisko()} - {uczen.PobierzPlec()}");
            }
        }
    }
}