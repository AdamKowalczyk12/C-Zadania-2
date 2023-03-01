namespace ConsoleApp1
{
    internal class Klient : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public int NumerDomu { get; set; }

        public override string ToString()
        {
            return $"IMIE: {Imie}, NAZWISKO: {Nazwisko}, ULICA: {Ulica}, MIEJSCOWOŚĆ: {Miejscowosc}, NUMER DOMU: {NumerDomu}";
        }

        public Klient(string imie, string nazwisko, string miejscowosc, string ulica, int numerDomu)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Miejscowosc = miejscowosc;
            Ulica = ulica;
            NumerDomu = numerDomu;
        }
    }
}
