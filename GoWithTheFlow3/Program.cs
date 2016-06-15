using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Should I go golfing today?");
            Console.WriteLine("Is it raining?");

            string userInput = Console.ReadLine();
            
                

            if (userInput == "no")
            {
                Console.WriteLine("Stay home and play WII golf!");
            }

            else if (userInput == "yes")
            {
                Console.WriteLine("Stay home and play WII golf! It's cheaper!");

            }

            Console.WriteLine("Use any club or iron to continue.");
            
            Console.WriteLine("Pick an Iron 1-9");
            double iron = Convert.ToDouble(Console.Read());

            if (iron < 3)
            {
                Console.WriteLine("You should use a club");
            }
            else
            {
                Console.WriteLine("Really? Thats the one you picked?");
            }
            Console.ReadLine();
        }
    }
}
