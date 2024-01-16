namespace ConsoleApp1
{

    public class Program
    {
        //Definera delegate typ 
        delegate void SimpleDelegate(string message);

        //Definera metod 
        static void DisplayMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
        static void Main(string[] args)
        {
            //Skapa en instans av delegate och koppla den till DisplayMessage method
            SimpleDelegate delegateInstance = DisplayMessage;

            delegateInstance("Hello, Nevena!");

            SimpleDelegate anotherDelegate = DisplayMessage;

            anotherDelegate("Hi, Nina!");
        }
    }
}
