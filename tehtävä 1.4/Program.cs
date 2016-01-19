using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_1._4
{
    class Program4
    {
        static void Main(string[] args)
        {

            int age;


            Console.WriteLine("Tell me your age: ");

            age = int.Parse(Console.ReadLine());

            if (age <= 18)
                Console.WriteLine("You're underage");
            else if (age > 18 && age <= 65)
                Console.WriteLine("You're adult");
            else
                Console.WriteLine("You're senior");





        }
    }
}
