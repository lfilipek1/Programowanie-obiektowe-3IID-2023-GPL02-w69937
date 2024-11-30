public class Sumator
{
    private int[] liczby;

    public Sumator(int[] liczby)
    {
        this.liczby = liczby;
    }

    public int Suma()
    {
        return liczby.Sum();
    }

    public int SumaPodziel3()
    {
        return liczby.Where(x => x % 3 == 0).Sum();
    }

    public int IleElementów()
    {
        return liczby.Length;
    }

    public void WypiszWszystkie()
    {
        foreach (var liczba in liczby)
        {
            Console.WriteLine(liczba);
        }
    }

    public void WypiszZakres(int lowIndex, int highIndex)
    {
        for (int i = lowIndex; i <= highIndex; i++)
        {
            if (i >= 0 && i < liczby.Length)
            {
                Console.WriteLine(liczby[i]);
            }
        }
    }
}
