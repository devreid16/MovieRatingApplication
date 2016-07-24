using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car();

            //set properties

            Car MyOtherCar = MyCar;

            Car MyThirdCar = new Car("Ford", "Escape", 2013, "Red");

            Car.
            MyCar = null;
            MyOtherCar = null;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalValue { get; set; }


        public Car()
        {
            //you could load from configuration file, database, etc.
            this.Make = "Nissan";
        }

        //override constructor method
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        
        }

        public static void myMethod()
        {

        }

    }
}