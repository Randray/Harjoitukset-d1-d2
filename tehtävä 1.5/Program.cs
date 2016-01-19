using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_1._5
{
    class Program
    {
        static void Main(string[] args)
        {

            int seconds=0;
            int hour=0;
            int minutes=0;
           

            Console.WriteLine("Give me time in seconds: ");

            seconds = int.Parse(Console.ReadLine());

            hour = seconds / 3600;
            seconds -= hour * 3600;
            minutes = seconds / 60;
            seconds -= minutes * 60;

            Console.WriteLine("Hours:"+hour);
            Console.WriteLine("minutes:" +minutes);
            Console.WriteLine("Seconds:" +seconds);


        }
    }
}
