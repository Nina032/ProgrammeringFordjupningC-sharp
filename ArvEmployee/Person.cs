using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArvEmployee
{
    public class Person : object
    {
        //Egenskaper
        public string? Name { get; set; }
        public DateTime DateofBirth { get; set; }


        //Delegate fält
        public event EventHandler? Shout;

        //datafält
        public int AngerLevel;

        //metod
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateofBirth:dddd}.");
        }
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                //om något lysnar på event
                //if (Shout != null)
                //{
                //    Shout(this, EventArgs.Empty)
                //}

                //C# 6 or later
                Shout?.Invoke(this, EventArgs.Empty);
            }

        }

        //overriden metod ToString
        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }
    }
}
