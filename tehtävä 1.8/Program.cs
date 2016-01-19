using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for(int i =0 ;i<numbers.Length;i++)
            {

                Console.WriteLine("Give me a number:");
                numbers[i] = int.Parse(Console.ReadLine());

            }


            int numbersmax = numbers.Max();

            Console.WriteLine("Your biggest number is " + numbersmax);

           
        }
    }
}
