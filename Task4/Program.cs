using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Days in number: ");
            int days = Convert.ToInt16(Console.ReadLine());

            int years = days / 365;
            int weeks = (days % 365)/7;
            int day = days - ((years * 365) + weeks);

            Console.WriteLine();
            Console.WriteLine(years +" Years; "+weeks+" weeks; "+day+ " Days");
            Console.ReadLine();
        }
    }
}
