using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad6
{
    class SortGodinaRastuci : IComparer<Auto>
    {
        //pocetak ugnjezdenih(nested) clasa 
        //klasa koja sortira prema godini u rastucem poretku
        int IComparer<Auto>.Compare(Auto a, Auto b)//MOGUCA GREDKA , TREBA X I Y
        {
            if (a.Godina > b.Godina)
                return 1;
            if (a.Godina < b.Godina)
                return -1;
            else
                return 0;
        }
    }
}
