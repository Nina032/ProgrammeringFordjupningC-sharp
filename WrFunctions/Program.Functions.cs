using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrFunctions
{
    partial class Program
    {
        static void TimesTable(byte number, byte size = 12)
        {
            WriteLine($"This is the {number} times table with {size} rows:");
            for (int row = 1; row <= size; row++)
            {
                WriteLine($"{row} X {number} = {row * number}");
            }
            WriteLine();
        }

        static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(message: $"The factorial function is defined for non-negative integers only. Input: {number}",
                    paramName: nameof(number));
            }
            else if (number == 0)
            {
                return 1;
            }
            checked //för overflow
            {
                return number * Factorial(number - 1);
            }
        }

        static void RunFactorial()
        {
            for (int i = -2; i <= 15; i++)
            {
                try
                {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch (OverflowException)
                {
                    WriteLine($" {i}! is too big for a 32-bit integer.");
                }
                catch (Exception ex)
                {
                    WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
                }
                
            }
        }
    }
}
