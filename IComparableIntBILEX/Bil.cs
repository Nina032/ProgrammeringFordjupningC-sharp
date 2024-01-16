using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableIntBILEX
{
    public class Bil : IComparable
    {
        private string tillverkare;
        private int år;

        public Bil(string tillverkare, int år)
        {
            this.tillverkare = tillverkare;
            this.år = år;
        }

        public int År { get; set; }
        public string Tillverkare { get; set; }

        private class SortÅrStigande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;

                if (c1.år > c2.år)
                    return 1;
                if (c1.år < c2.år)
                    return -1;
                else
                    return 0;
            }
        }

        private class SortÅrFallande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;

                if (c1.år < c2.år)
                    return 1;
                if (c1.år > c2.år)
                    return -1;
                else
                    return 0;
            }
        }

        private class SortTillverkareFallande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;

                return String.Compare(c2.tillverkare, c1.tillverkare);
            }
        }

        //Implementera IComparable CompareTo för att sortera efter tillverkare (stigande)
        int IComparable.CompareTo(object obj)
        {
            Bil c = (Bil)obj;
            return String.Compare(this.tillverkare, c.tillverkare);
        }

        //En metod som returnerar ett IComparer objekt för sortering
        public static IComparer sortYearAscending()
        {
            return new SortÅrStigande();
        }

        //En metod som returnerar ett IComparer objekt for sortering 
        public static IComparer sortYearDescending()
        {
            return new SortÅrFallande();
        }

        //En metod som returnerar ett IComparer objekt for sortering 
        public static IComparer sortMakeDescending()
        {
            return new SortTillverkareFallande();
        }
    }
}
