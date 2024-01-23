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

            john.WriteConsole();

            john.EmployeeCode = "JJ001";
            john.HireDate = new(year: 2014, month: 11, day: 23);

            Console.WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

            Console.WriteLine(john.ToString());

        }
    }
}
