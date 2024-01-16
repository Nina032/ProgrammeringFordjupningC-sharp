namespace DelegatesEvents
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person harry = new()
            {
                Name = "Harry",
                DateofBirth = new(year: 2001, month: 3, day: 25)
            };
            harry.WriteToConsole();


            //harry.Shout = Harry_Shout;

            //assign event handler methods to Shout event
            harry.Shout += Harry_Shout;
            harry.Shout += Harry_Shout2;

            //anropa Poke
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
        }
    }
}
