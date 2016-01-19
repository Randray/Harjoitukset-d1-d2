using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Give me a year: ");

            year = int.Parse(Console.ReadLine());


            if (year % 4 == 0 || year % 400 == 0)
                Console.WriteLine("This year is leap year");
            else
                Console.WriteLine("This year is not leap year");

        }
    }
}
