using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DyrektorNaczelny : Dyrektor
    {
        public double KwotaSpecjalna { get; set; }

        public DyrektorNaczelny(string naz, string im, double pp, double ks) : base(naz, im, pp)
        {
            KwotaSpecjalna = ks;
        }

        public override double Premia()
        {
            return base.Premia() + KwotaSpecjalna;
        }
    }
}
