using static System.Console;
using System;
using System.Numerics;
using System.Text.RegularExpressions;
namespace dotNetTyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "Hello";
            //String s2 = "World";
            //WriteLine($"{s1} {s2}");

            //WriteLine($"int.MaxValue = {int.MaxValue:N0}");
            //WriteLine($"nint.MaxValue = {nint.MaxValue:N0}");

            ////Complex numbers
            ////(a+bi) + (c+di) = (a+c) + (b+d)i
            //WriteLine("Working with complex numbers");

            //Complex c1 = new(real: 4, imaginary: 2);
            //Complex c2 = new(real: 3, imaginary:7);
            //Complex c3 = c1 + c2;
            
            ////använder ToString metod
            //WriteLine($"{c1} added to {c2} is {c3}");

            ////egen format för utskrift
            //WriteLine("{0} + {1}i added to {2} + {3}i is {4} + {5}i",
            //    c1.Real, c1.Imaginary,
            //    c2.Real, c2.Imaginary,
            //    c3.Real, c3.Imaginary);

            //String medlemmar
            //string city = "London";
            //WriteLine($"{city} is {city.Length} characters long");

            //WriteLine($"First char is {city[0]} and fourth is {city[3]}.");

            //string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellin";
            //string[] citiesArray = cities.Split(',');
            //WriteLine($"There are {citiesArray.Length} cities in the array");
            //foreach (string item in citiesArray)
            //{
            //    WriteLine(item);
            //}

            //string fullName = "Nevena Kicanovic";
            //int indexOfTheSpace = fullName.IndexOf(' ');

            //string firstName = fullName.Substring(
            //    startIndex:0, length:indexOfTheSpace);

            //string lastName = fullName.Substring(
            //    startIndex: indexOfTheSpace + 1);

            //WriteLine($"Original: {fullName}");
            //WriteLine($"Swapped: {lastName}, {firstName}");

            //string company = "Microsoft";
            //bool startsWithM = company.StartsWith("M");

            //bool endsWithM = company.EndsWith("M");

            //bool containsF = company.Contains("f");


            //validera input 
            Write("Enter your age:");
            string input = ReadLine()!; //null-forgiving

            Regex ageChecker = new(@"^[0-9]{2}$");

            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!"); 
            }
            else
            {
                WriteLine($"This is not a valid age: {input}");
            }
            

        }
    }
}
