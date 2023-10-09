using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int avg = 0;
            for(int i = 1; i<=5; i++)
            {
                Console.Write("Enter number "+i+": ");
                int num = Convert.ToInt16(Console.ReadLine());
                avg += num; 
            }
            Console.WriteLine("Average is: " + (avg / 5));
            Console.ReadLine();
        }
    }
}