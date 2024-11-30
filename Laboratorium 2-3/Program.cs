// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Osoba osoba = new Osoba("Jan", "Kowalski", 30, "12345678901");
        Console.WriteLine(osoba.PrzedstawSie());

        Licz licz = new Licz(120);
        Console.WriteLine($"Aktualna wartość: {licz.Wartosc}");
        licz.WypiszStan();

        int[] liczby = { 3, 6, 9, 12, 15 };
        Sumator sumator = new Sumator(liczby);
        Console.WriteLine($"Suma wszystkich liczb: {sumator.Suma()}");
        Console.WriteLine($"Suma liczb podzielnych przez 3: {sumator.SumaPodziel3()}");
        Console.WriteLine($"Ile elementów w tablicy: {sumator.IleElementów()}");
        sumator.WypiszWszystkie();
    }
}
