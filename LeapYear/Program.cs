using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year: ");
            int year = Convert.ToInt16(Console.ReadLine());

            if ((year%400 ==0) || (year % 4 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("The year " + year + " is a Leap year.");
            }
            else
            {
                Console.WriteLine("The year " + year + " is not a Leap year.");
            }
            Console.Read();
        }
    }
}
