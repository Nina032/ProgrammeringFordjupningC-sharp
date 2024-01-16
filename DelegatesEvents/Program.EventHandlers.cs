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
        static void Harry_Shout(object? sender, EventArgs e)
        {
            if (sender is null) return;
            Person? p = sender as Person;
            if (p is null) return;

            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }

        static void Harry_Shout2(object? sender, EventArgs e)
        {
            if (sender is null) return;
            Person? p = sender as Person;
            if (p is null) return;

            WriteLine($"Stop it!");
        }

    }
}
