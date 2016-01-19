using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekaolioprojekti
{



    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("Anna luku > 1");
            luku = int.Parse(Console.ReadLine());
            switch (luku)
            {
                case 1: Console.WriteLine("Annoit luvun yksi"); break;
                case 2: Console.WriteLine("Annoit luvun kaksi"); break;
                case 3: Console.WriteLine("Annoit luvun kolme"); break;
                default: Console.WriteLine("Annoit muun luvun"); break;

            }
            
           


        }

    }
    }

