using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad6
{
    public class Auto : IComparable
    {
        private string proizv;
        private int god;

        public Auto (string proizvodjac, int godina)
        {
            proizv = proizvodjac;
            god = godina;
        }

        public int Godina
        {
            get { return god; } set { god = value; }
        }
        public string Proizvodjac
        {
            get { return proizv; } set { proizv = value; }
        }

        int IComparable.CompareTo(object obj)//primena IComparable.CompareTo za sortiranjre prema proizvodjacu (rastuce)
        {
            Auto c = (Auto)obj;
            return String.Compare(this.proizv, c.proizv);
        }
        //=================================================================
        public static IComparer<Auto> sortirajGodinuRastuci()
        {
            return (IComparer<Auto>)new SortGodinaRastuci();
        }
        //==================================================================
        public static IComparer<Auto> sortirajGodinuOpadajuci()
        {
            return (IComparer<Auto>)new SortGodinaOpadajuci();
        }
        //===================================================================
        public static IComparer<Auto> sortirajProizvodjacaOpadajuci()
        {
            return (IComparer<Auto>)new SortProizvodjacOpadajuci();
        }
        //==================================================================
    }
}
