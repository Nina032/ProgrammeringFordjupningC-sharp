using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterfacePlay.Program;
using static System.Console;

namespace InterfacePlay
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("DVD player is pausing.");
        }

        public void Play()
        {
            WriteLine("DVD player is playing.");
        }

        public void Stop()
        {
            WriteLine("Implementing stop!");
        }
    }
}
