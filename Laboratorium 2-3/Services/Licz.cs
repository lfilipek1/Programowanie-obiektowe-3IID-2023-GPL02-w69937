public class Licz
{
    private int wartosc;

    public Licz(int wartosc)
    {
        this.wartosc = wartosc;
    }

    public void Dodaj(int liczba)
    {
        wartosc += liczba;
    }

    public void Odejmij(int liczba)
    {
        wartosc -= liczba;
    }

    public int Wartosc
    {
        get { return wartosc; }
    }

    public void WypiszStan()
    {
        Console.WriteLine(wartosc);
    }
}
