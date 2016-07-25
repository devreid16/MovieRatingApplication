using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes
{
    class Program
    {
        //String data type demo
        static void Main(string[] args)
        {
           string animal = "Dog";
           string name = "Nicole";
           string activity = "walk";

            var sentence = $" {name} + {animal} + {activity}";

            Console.WriteLine($" {name} takes her {animal} for a {activity}.");
              Console.ReadLine();               
        }
    }
   
}

