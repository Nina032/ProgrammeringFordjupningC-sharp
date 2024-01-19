namespace IComparableIntBILEX
{
    public class Program
    {
        static void InmätningBilar(Bil c)
        {
            Console.WriteLine("Ange bilinformation: ");
            Console.Write("Tillverkare: ");
            c.Tillverkare = Console.ReadLine();
            Console.WriteLine("Tillverkningsår: ");
            c.År = int.Parse(Console.ReadLine());
        }

        static void UtskriftBilar(Bil[] arrayBilar)
        {
            foreach (Bil c in arrayBilar)
            { 
                Console.WriteLine(c.Tillverkare + "\t\t" + c.År); 
            }
        }
        static void Main(string[] args)
        {
            //24_01_19
            int i, n;
            Console.WriteLine("Ange antal bilar\n");
            n = int.Parse(Console.ReadLine());
            // Skapa objekt array av klassen Bil..
            Bil[] arrayBilar = new Bil[n];
            for (i = 0; i < n; i++)
            {
                arrayBilar[i] = new Bil("", 0);
                InmätningBilar(arrayBilar[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("En osorterad array\n");
            UtskriftBilar(arrayBilar);
            // Sortering i stigande ordning efter tillverkare
            Array.Sort(arrayBilar);
            Console.WriteLine("\nArray sorterad efter tillverkare (stigande ordning)\n");
            UtskriftBilar(arrayBilar);
            //Sortering i stigande ordning efter tillverkningsår med IComparer.
            Array.Sort(arrayBilar, Bil.sortYearAscending());
            Console.WriteLine("\nArray sorterad efter tillverkningsår (stigande ordning)\n");
            UtskriftBilar(arrayBilar);
            //Sortering i fallande ordning efter tillverkare med IComparer.
            Console.WriteLine("\nArray sorterad efter tillverkare (fallande ordning)\n");
            Array.Sort(arrayBilar, Bil.sortMakeDescending());
            UtskriftBilar(arrayBilar);
            //Sortering i fallande ordning efter tillverkningsår med IComparer.
            Array.Sort(arrayBilar, Bil.sortYearDescending());
            Console.WriteLine("\nArray sorterad efter tillverkningsår (fallande ordning)\n");
            UtskriftBilar(arrayBilar);
            Console.ReadKey();

        }
    }
}
