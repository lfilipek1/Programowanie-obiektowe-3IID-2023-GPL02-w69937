using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wybierz");
                Console.WriteLine("1. Czy parzysta");
                Console.WriteLine("2. Liczby parzyste");
                Console.WriteLine("3. Silnia");
                Console.WriteLine("4. Gra");
                Console.WriteLine("0. Wyjście");

                var n = Console.ReadLine();

                switch (int.Parse(n))
                {
                    case 1:
                        CheckEven(); // Zadanie 1
                        break;
                    case 2:
                        WriteEven(); // Zadanie 2
                        break;
                    case 3:
                        Console.WriteLine("Podaj liczbę:");
                        var siln = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine(Silnia(int.Parse(siln))); // Zadanie 3
                        Console.WriteLine();
                        break;
                    case 4:
                        Game(); // Zadanie 4
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        // Zadanie 1: Funkcja sprawdzająca, czy liczba jest parzysta
        static void CheckEven()
        {
            Console.WriteLine("Podaj liczbę:");
            var liczba = Console.ReadLine();

            if (int.TryParse(liczba, out int num))
            {
                Console.WriteLine();
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} jest liczbą parzystą.");
                }
                else
                {
                    Console.WriteLine($"{num} jest liczbą nieparzystą.");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wprowadź poprawną liczbę.");
                Console.WriteLine();
            }
        }

        // Zadanie 2: Funkcja do wypisywania liczb parzystych od 0 do n
        static void WriteEven()
        {
            Console.WriteLine("Podaj n:");
            var n = Console.ReadLine();

            if (int.TryParse(n, out int max))
            {
                Console.WriteLine();
                for (var i = 2; i <= max; i += 2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wprowadź poprawną liczbę.");
                Console.WriteLine();
            }
        }

        // Zadanie 3: Funkcja obliczająca silnię rekurencyjnie
        static int Silnia(int x)
        {
            if (x == 0) return 1;
            return Silnia(x - 1) * x;
        }

        // Zadanie 4: Funkcja gry w zgadywanie liczby
        static void Game()
        {
            Random rand = new Random();
            int liczba = rand.Next(1, 101);
            int proba = 0;
            int zgaduj = 0;

            Console.WriteLine("Zgadnij liczbę (od 1 do 100):");

            while (zgaduj != liczba)
            {
                proba++;
                Console.WriteLine();
                Console.WriteLine($"Próba {proba}: Podaj liczbę:");
                if (int.TryParse(Console.ReadLine(), out zgaduj))
                {
                    Console.WriteLine();
                    if (zgaduj < liczba)
                    {
                        Console.WriteLine("Za mało! Spróbuj ponownie.");
                    }
                    else if (zgaduj > liczba)
                    {
                        Console.WriteLine("Za dużo! Spróbuj ponownie.");
                    }
                    else
                    {
                        Console.WriteLine($"Brawo! Odgadłeś liczbę {liczba} za {proba} razem.");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wprowadź poprawną liczbę.");
                    Console.WriteLine();
                }
            }
        }
    }
}
