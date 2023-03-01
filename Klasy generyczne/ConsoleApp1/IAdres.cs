using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IAdres
    {
        string Miejscowosc { get; set; }
        string Ulica { get; set; }
        int NumerDomu { get; set; }
    }
}
