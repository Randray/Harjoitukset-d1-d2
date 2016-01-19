using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä1._6
{
    class Program
    {
        static void Main(string[] args)
        {

            float casoline;
            float price;
            float distance;

            Console.WriteLine("Give me your traveling distance:");
            distance = float.Parse(Console.ReadLine());


            casoline= distance/100*7.02f;
            price = casoline * 1.595f;

            Console.Write("With your traveling distance, your car consume " + casoline);
            Console.Write(" liters and  it will cost you " + price);
            Console.WriteLine(" euros");
        }
    }
}
