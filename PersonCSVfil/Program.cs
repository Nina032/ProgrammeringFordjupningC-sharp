using System.Text;
namespace PersonCSVfil
{
    class Person
    {
        public string Name { get; set; }
        public int  Age { get; set; }
        public string City { get; set; }

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public string ToCSVString()
        {
            return $"{Name}, {Age}, {City}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person 4 input
            Console.WriteLine("Ange information för person ");
            Console.Write("Namn: ");
            string name4 = Console.ReadLine();

            Console.Write("Ålder: ");
            int age4 = int.Parse(Console.ReadLine());

            Console.Write("Stad: ");
            string city4 = Console.ReadLine();

            //lägg till  några instancer av Person-klassen
            Person person1 = new Person("Alice", 25, "Stockholm");
            Person person2 = new Person("Alice", 25, "Stockholm");
            Person person3 = new Person("Alice", 25, "Stockholm");
            Person person4 = new Person(name4, age4, city4);


            //Lista med personer
            List<Person> people = new List<Person> { person1, person2, person3, person4};

            //Spara data till CSV-fil
            string csvFilePath = "people.csv";

            using (StreamWriter writer = new StreamWriter(csvFilePath, false, Encoding.UTF8)) 
            {
                //Skriv header
                writer.WriteLine("Name,Age,City");

                //Skriv data för varje person
                foreach (var person in people)
                {
                    writer.WriteLine(person.ToCSVString());
                }

            }

            Console.WriteLine($"Data har sparats till {csvFilePath}");


            //Läser från CSV-fil och skriver till konsolen


        }
    }
}
