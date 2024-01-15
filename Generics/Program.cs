namespace Generics
{
    //Generic method example
    public class GenericExample
    {
        public static void PrintElements<T>(T[] elements)
        {
            foreach (T element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
    //Generic class
    public class GenericList<T>
    {
        private T[] items;
        private int currentIndex = 0;

        public GenericList(int size)
        {
            items = new T[size];
        }

        public void Add(T item)
        {
            if (currentIndex < items.Length)
            {
                items[currentIndex] = item;
                currentIndex++;
            }
        }
        public void PrintItems()
        {
            foreach(T item in items)
            {
                if(item != null)
                    Console.WriteLine(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Använda generic metod
            int[] intArray = { 1, 2, 3, 4, 5 };
            string[] stringArray = { "apple", "banana", "cherry" };

            Console.WriteLine("Printing integers: ");
            GenericExample.PrintElements(intArray);

            Console.WriteLine("Printing strings: ");
            GenericExample.PrintElements(stringArray);

            //Använda generic class
            GenericList<int> intList = new GenericList<int>(5);
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            intList.Add(50);
            //intList.Add(60);

            Console.WriteLine("Int lista");
            intList.PrintItems();

            GenericList<string> stringList = new GenericList<string>(3);
            stringList.Add("John");
            stringList.Add("Jane");

            Console.WriteLine("String lista");
            stringList.PrintItems();

        }
    }
}
