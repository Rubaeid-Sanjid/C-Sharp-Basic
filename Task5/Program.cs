using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt16(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine();
                Console.WriteLine(num + " * " + i + " = " + result);
            }
            Console.ReadLine();
        }
    }
}
