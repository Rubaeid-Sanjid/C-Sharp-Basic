using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double ans=0;

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operation (+, -, *, /): ");
            string Op = Console.ReadLine();

            switch(Op)
            {
                case "+":
                    ans = num1 + num2;
                    break;
                case "-":
                    ans = num1 - num2;
                    break;
                case "*":
                    ans = num1 * num2;
                    break;
                case "/":
                    ans = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            Console.WriteLine("-------------");
            Console.WriteLine(num1 + " "+Op+ " "+ num2 + " = " + ans);
            Console.WriteLine("-------------");
            Console.ReadLine();
        }
    }
}
