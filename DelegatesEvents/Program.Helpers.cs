using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DelegatesEvents
{
    partial class Program
    {
        static void OutputPeopleNames(IEnumerable<Person?> people, string title) 
        {
            WriteLine(title);
            foreach (var person in people)
            {

            }
        }
    }
}
