namespace ConsoleApp1
{
    internal interface IOsoba : IAdres, IComparable<IOsoba>
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
    }
}
