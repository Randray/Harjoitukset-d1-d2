using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[5];



                for(int i= 0;i<table.Length ;i++)
            {


                Console.Write("Give me a number: ");

                table[i] = int.Parse(Console.ReadLine());




            }
            Array.Reverse(table);


            Console.WriteLine("Your numbers were: " + table[0] + table[1] + table[2] + table[3] + table[4]);



        }
    }
}
