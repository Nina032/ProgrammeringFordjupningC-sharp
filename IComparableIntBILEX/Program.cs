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
          
        }
    }
}
