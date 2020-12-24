using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad6
{
    class SortProizvodjacOpadajuci : IComparer<Auto>
    {//klasa koja sortira prema proizvodjacu u opadajucem poretku
        int IComparer<Auto>.Compare(Auto a, Auto b)
        {
            return String.Compare(b.Proizvodjac, a.Proizvodjac);
        }
    }
}
