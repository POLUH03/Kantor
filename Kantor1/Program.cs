class Program
{
    public static void Kantor()
    {
        double eur = 0.92;
        double chf = 0.87;
        double gbp = 0.80;
        double usd = 0.26;
        Console.WriteLine("Podaj ilość zlotowek na wymiane: ");
        double pln = Convert.ToDouble(Console.ReadLine());

        double PLNonUSD = pln * usd;

        Console.WriteLine("Wybierz walute na która chcesz wymienic zlotowki");
        Console.WriteLine("1.Euro");
        Console.WriteLine("2.Funt szwajcarski");
        Console.WriteLine("3.Funt brytyjski");
        int waluta = Int32.Parse(Console.ReadLine());
        switch (waluta)
        {
            case 1:
                Console.WriteLine("Twoja ilosc po przewalutowaniu wynosi: " + PLNonUSD * eur);
                break;
            case 2:
                Console.WriteLine("Twoja ilosc po przewalutowaniu wynosi: " + PLNonUSD * chf);
                break;
            case 3:
                Console.WriteLine("Twoja ilosc po przewalutowaniu wynosi: " + PLNonUSD * gbp);
                break;

        }
    }
    static void Main(string[] args)
    {
        Kantor();
    }
}