using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your score: ");
            int score = Convert.ToInt16(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("A+");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 50 && score < 60)
            {
                Console.WriteLine("D");
            }
            else if (score >= 0 && score < 50)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Invalid Score.");
            }
            Console.ReadLine();
        }
    }
}
