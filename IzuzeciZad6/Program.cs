using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] automobil = new Auto[5]
            {
                new Auto("Ford", 2006),
                new Auto("Opel", 2016),
                new Auto("Audi", 2010),
                new Auto("Honda", 2003),
                new Auto("Kia", 2014)
            };

            Console.WriteLine("Nesortirani niz: ");
            foreach(Auto a in automobil)
            {
                Console.WriteLine(a.Proizvodjac + "\t\t" + a.Godina);
            }
            //------------------------------------------------------------
            //sortiranje u rastucem poretku prema proizvodjacu
            Array.Sort(automobil); //ovde se vidi efekat IComparable
            Console.WriteLine("Niz sortiran prema proizvodjacu u rastucem poretku: ");
            foreach (Auto a in automobil)
            {
                Console.WriteLine(a.Proizvodjac + "\t\t" + a.Godina);
            }
            //------------------------------------------------------------
            //sortiranje u opadajucem poretku prema proizvodjacu sa IComparer

            Array.Sort(automobil, Auto.sortirajProizvodjacaOpadajuci());
            Console.WriteLine("Niz sortiran prema proizvodjacu u opadajucem poretku: ");

            foreach (Auto a in automobil)
            {
                Console.WriteLine(a.Proizvodjac + "\t\t" + a.Godina);
            }

            //------------------------------------------------------------
            //sortiranje u rastucem poretku prema godini proizvodnje sa IComparer

            Array.Sort(automobil, Auto.sortirajGodinuRastuci());
            Console.WriteLine("Niz sortiran prema godini proizvodnje u rastucem poretku: ");

            foreach (Auto a in automobil)
            {
                Console.WriteLine(a.Proizvodjac + "\t\t" + a.Godina);
            }

            //------------------------------------------------------------
            //sortiranje u opadajucem poretku prema godini proizvodnje sa IComparer

            Array.Sort(automobil, Auto.sortirajGodinuOpadajuci());
            Console.WriteLine("Niz sortiran prema godini proizvodnje u opadajucem poretku: ");

            foreach (Auto a in automobil)
            {
                Console.WriteLine(a.Proizvodjac + "\t\t" + a.Godina);
            }

            Console.ReadLine();
        }
    }
} 
