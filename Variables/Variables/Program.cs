﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;

            //x = 7;
            //y = x + 3;
            //Console.WriteLine("The number is " + y);

            int x = 7;
            //string y = "Angie";
            string y = "5";
            string myFirstTry = x.ToString() + y;
            Console.WriteLine(myFirstTry);

            //int mySecondTry = x + y;
            //int mySecondTry = x + int.Parse(y);

            Console.ReadLine();
        }
    }
}
