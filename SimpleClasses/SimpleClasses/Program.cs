using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Car MyNewCar = new Car();

            //setting properties
            MyNewCar.Make = "Toyota";
            MyNewCar.Model = "Camry";
            MyNewCar.Year = 2007;
            MyNewCar.Color = "Grey";

            //getting properties
            Console.WriteLine("{0} - {1} - {2}",
                MyNewCar.Make,
                MyNewCar.Model,
                MyNewCar.Color);

            // double MarketValue = determineMarketValue(MyNewCar);
            Console.WriteLine("Car's Value: {0:C}", MyNewCar.determineMarketValue());

            Console.Read();

        }
        //"car" is an input parameter name for this, while "Car"is the data type
        private static double determineMarketValue(Car car)
        {
            double carValue = 7000.00;

            return carValue;
        }

    }


    class Car
    {
        public string Make { get; set; } //code snippet
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //method inside class
        public double determineMarketValue()
        {
            double carValue = 100.00;

            if (this.Year > 1999)
                carValue = 10000.00;
            else
                carValue = 2000.00;

            return carValue;
        }

    }


    public class Girl
    {
        public string Height { get; set; }
        public string HairColor { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }

    }


}
