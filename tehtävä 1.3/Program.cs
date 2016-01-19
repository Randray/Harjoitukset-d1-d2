using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1 = 0;
            float number2 = 0;
            float number3 = 0;
            float add;
            float average;

            Console.WriteLine("Give me number:" );
             number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me second number:");
            number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me a third number:");
            number3 = float.Parse(Console.ReadLine());

            add = number1 + number2 + number3;
            average = (number3 + number2 + number1) / 3;

            Console.Write("The sum of your number is " + add);
            Console.Write(" and there average is " + average);

        }
    }
}
