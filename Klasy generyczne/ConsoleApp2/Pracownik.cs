using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Pracownik : IPremia, IComparable<Pracownik>
    {
        public string nazwisko;
        public string imie;

        public double PodstawaPremii { get; set; }

        public Pracownik(string naz, string im, double podstawaPremii)
        {
            nazwisko = naz;
            imie = im;
            PodstawaPremii = podstawaPremii;
        }

        public virtual double Premia() => PodstawaPremii * 0.1;

        public int CompareTo(Pracownik? other)
        {
            if(other == null) return 1;

            return imie.CompareTo(other.imie) + nazwisko.CompareTo(other.nazwisko);
        }
    }
}
