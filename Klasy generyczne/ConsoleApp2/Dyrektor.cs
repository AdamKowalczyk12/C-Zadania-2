using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Dyrektor : Pracownik
    {
        public Dyrektor(string naz, string im, double pp) : base(naz, im, pp) { }
        public override double Premia()
        {
            return base.Premia() * 2;
        }
    }
}
