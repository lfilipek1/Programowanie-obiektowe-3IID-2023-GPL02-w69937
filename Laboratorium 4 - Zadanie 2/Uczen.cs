using System;

namespace Laboratorium_4___Zadanie_2
{
    public class Uczen : Osoba
    {
        private string szkola;
        private bool mozeSamWrocicDoDomu;

        public Uczen(string imie, string nazwisko, string pesel, string szkola, bool mozeSamWrocicDoDomu)
            : base(imie, nazwisko, pesel)
        {
            this.szkola = szkola;
            this.mozeSamWrocicDoDomu = mozeSamWrocicDoDomu;
        }

        public void UstawSzkole(string szkola)
        {
            this.szkola = szkola;
        }

        public void ZmienSzkole(string nowaSzkola)
        {
            szkola = nowaSzkola;
        }

        public void UstawCzyMozeSamWrocic(bool pozwolenie)
        {
            mozeSamWrocicDoDomu = pozwolenie;
        }

        public string Informacja()
        {
            return PobierzWiek() < 12
                ? mozeSamWrocicDoDomu ? "Uczeń może wracać samodzielnie." : "Uczeń nie może wracać samodzielnie."
                : "Uczeń może wracać samodzielnie.";
        }

        public override string PobierzInformacjeOEdukacji()
        {
            return $"Uczeń {imie} {nazwisko}, szkoła: {szkola}.";
        }

        public override bool CzyMozeSamWrocicDoDomu()
        {
            return PobierzWiek() >= 12 || mozeSamWrocicDoDomu;
        }
    }
}