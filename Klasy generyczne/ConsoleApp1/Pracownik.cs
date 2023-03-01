using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pracownik : IOsoba
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

        public int CompareTo(IOsoba? other)
        {
            throw new NotImplementedException();
        }

        public Pracownik(string imie, string nazwisko, string miejscowosc, string ulica, int numerDomu)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Miejscowosc = miejscowosc;
            Ulica = ulica;
            NumerDomu = numerDomu;
        }
    }
}
