using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_1._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnro = new Random();
            int randomn = rnro.Next(1, 100);
            int nro = 0;


            do
            {
                Console.Write("Quoes the number :");
                nro = int.Parse(Console.ReadLine());

                if (nro > randomn)
                {
                    Console.WriteLine("The number is smaller");

                }


                else if (nro < randomn)
                {
                    Console.WriteLine("The number is bigger");
                }
                else
                {
                    Console.WriteLine("You got it,bye");
                }


            } while (nro != randomn);






        }
    }
}
