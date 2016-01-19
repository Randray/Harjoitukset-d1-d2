using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_1._10
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] table = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            foreach(int element in table)
            {

                if(element % 2 ==0)
                {
                    Console.WriteLine("HEP!!!!!");

                }
                else
                {
                    Console.WriteLine("Nope");

                }



            }



        }
    }
}
