using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace harjoitus_1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[5];
            int sum=0;

            for(int l=0; l<table.Length ;l++)
            {

                Console.WriteLine("Give your score: ");

                table[l] = int.Parse(Console.ReadLine()); 


            }

            Array.Sort(table);

            for(int g=1 ;g<table.Length-1 ;g++ )
            {

                sum += table[g];


            }

            Console.WriteLine("The score is  "+ sum);
        }
    }
}
