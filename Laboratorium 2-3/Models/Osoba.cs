public class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;
    private string pesel;

    public Osoba(string imie, string nazwisko, int wiek, string pesel)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.wiek = wiek >= 0 ? wiek : 0;
        this.pesel = pesel;
    }

    public string Imie
    {
        get { return imie; }
        set { imie = value; }
    }

    public string Nazwisko
    {
        get { return nazwisko; }
        set { nazwisko = value; }
    }

    public int Wiek
    {
        get { return wiek; }
        set { wiek = value >= 0 ? value : 0; }
    }

    public string Pesel
    {
        get { return pesel; }
    }

    public string PrzedstawSie()
    {
        return $"Nazywam się {imie} {nazwisko} i mam {wiek} lat";
    }
}
