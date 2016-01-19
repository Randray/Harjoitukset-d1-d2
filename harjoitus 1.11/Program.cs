using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Give me a numeber: ");
            number = int.Parse(Console.ReadLine());


            for(int k=0; k < number ;k++)
            {

                

                for (int l=0;l<=k ;l++)
                {
                    Console.Write("*");


                }

                Console.WriteLine("");
            }





        }
    }
}
