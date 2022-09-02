using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabSjokoladeLotteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random tilfeldig = new Random();
            string[] navn = { "Nicolai", "Arne", "Robin S", "Robin B", "Brendon", "Emil", "Scott", "Jan", "Madelen", "Sander", "Kornel", "Dennis", "Muhanad", "Jonas", "Hisham" };
            int NavnRandom;
            int rounds = tilfeldig.Next(35, 60);

            for(int i = 0; i < rounds; i++)
            {
                NavnRandom = tilfeldig.Next(0, 14);
                Console.Clear();
                Console.WriteLine(navn[NavnRandom]);
                Thread.Sleep(300);
            }
            Console.Write("!GRATULERER!");
            Console.ReadLine();
        }
    }

}
