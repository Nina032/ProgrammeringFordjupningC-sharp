namespace ArvEmployee
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee john = new()
            {
                Name = "John Jones",
                DateofBirth = new(year:1990, month:7, day:28)
            };

            john.WriteToConsole();

            john.EmployeeCode = "JJ001";
            john.HireDate = new(year: 2014, month: 11, day: 23);

            Console.WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

            Console.WriteLine(john.ToString());


            //Skapa en ny employee
            Employee aliceInEmplyee = new() 
            { Name = "Alice", EmployeeCode = "AA123" };

            Person aliceInPerson = aliceInEmplyee;
            aliceInEmplyee.WriteToConsole();
            aliceInPerson.WriteToConsole();

            Console.WriteLine(aliceInEmplyee.ToString());
            Console.WriteLine(aliceInPerson.ToString());

            if (aliceInPerson is Employee)
            {
                Console.WriteLine($"{nameof(aliceInPerson)} IS an Employee");
                Employee explicitAlice = (Employee)aliceInPerson;
                //göra något med explicitAlice i programmet
                //med tygghet att vi jobbar med Employee objekt
            }

        }
    }
}
