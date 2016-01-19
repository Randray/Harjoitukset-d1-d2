using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_1._17
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] table1 = { 10, 20, 30, 40, 50 };
            int[] table2 = { 5, 15, 25, 35, 45, };
            int[] table3 = table1.Concat(table2).ToArray();


            Console.Write("First table is:");
            for(int i=0;i<table1.Length ;i++ )
            {
                Console.Write(table1[i]);

            }
            Console.WriteLine("");
            Console.Write("Second table is:");
            for (int i = 0; i < table2.Length; i++)
            {
                Console.Write(table2[i]);

            }
            Console.WriteLine("");

            Array.Sort(table3);

            Console.Write("Final table is:");
            for (int i = 0; i < table3.Length; i++)
            {
                Console.Write(table3[i]);

            }



        }
    }
}
