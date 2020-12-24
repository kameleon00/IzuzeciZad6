using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad6
{
    class SortGodinaOpadajuci : IComparer<Auto>
    {
        int IComparer<Auto>.Compare(Auto a, Auto b)
        {//klasa koja sortira prema godini u opadajucem poretku
            if (a.Godina < b.Godina)
                return 1;
            if (a.Godina > b.Godina)
                return -1;
            else
                return 0;
        }
    }
}
