using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalAngle = 0;
            for(int i = 1; i<=3; i++)
            {
                Console.Write("Enter angle " +i+ " : ");
                int angle = Convert.ToInt16(Console.ReadLine());
                totalAngle += angle; 
            }
            
            if (totalAngle <= 180)
            {
                Console.WriteLine("Triangle can be formed.");           
            }
            else
            {
                Console.WriteLine("Triangle can not be formed.");
            }
            Console.ReadLine();
        }
    }
}
