using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_and_Object_CAR_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.name = "BMW Gusheshe";
            car1.colour = "Red";
            car1.yearofrelease = 1995;

            Car car2 = new Car();
            car2.name = "Jeep SRT8";
            car2.colour = "Black";
            car2.yearofrelease = 2014;

            Car car3 = new Car();
            car3.name = "VW Golf 8";
            car3.colour = "White";
            car3.yearofrelease = 2022;

            Console.WriteLine(car1.name + " " + car1.yearofrelease);
            Console.WriteLine(car2.name +" " + car2.yearofrelease);
            Console.WriteLine(car3.name +" " + car3.colour );
        }
    }
}
