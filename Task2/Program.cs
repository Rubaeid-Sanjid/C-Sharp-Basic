using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your 1kg potato price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your product quantity: ");
            double quantity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the product tax: ");
            string taxUnit = Console.ReadLine();

            string tx = taxUnit.Substring(0, taxUnit.Length-1);
            //Console.WriteLine(tx);

            double taxes = Convert.ToDouble(tx);

            double tax = (taxes/100);
            double total = ((price + tax) * quantity);

            Console.WriteLine("Total Price = "+total);
            Console.ReadLine();
        }
    }
}
