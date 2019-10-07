using System;

namespace circle_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle calculator!");

            Console.WriteLine("Enter cicle radius:");
            string radi = Console.ReadLine();
            decimal radid = Convert.ToDecimal(radi);

            decimal area = 0;

            area =
                3.141592m * (radid * radid);

            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}
