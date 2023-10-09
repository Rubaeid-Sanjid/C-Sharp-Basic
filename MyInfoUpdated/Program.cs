using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInfoUpdated
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter your CGPA: ");
            double cg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Department: ");
            string department = Console.ReadLine();
            Console.Write("Enter your Course: ");
            string courseName = Console.ReadLine();
            Console.Write("Enter your Semester: ");
            int semester = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter your University: ");
            string university = Console.ReadLine();
            Console.Write("Enter your Blood Group: ");
            string bloodGrp = Console.ReadLine();
            Console.Write("Enter your Nationality: ");
            string nationality = Console.ReadLine();
            Console.Write("Enter your Country: ");
            string country = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Name            :"+ name);
            Console.WriteLine("ID              :" + id);
            Console.WriteLine("CGPA            :" + cg);
            Console.WriteLine("Department      :" + department);
            Console.WriteLine("Course          :" + courseName);
            Console.WriteLine("Semester        :" + semester);
            Console.WriteLine("University      :" + university);
            Console.WriteLine("Blood Group     :" + bloodGrp);
            Console.WriteLine("Nationality     :" + nationality);
            Console.WriteLine("Country         :" + country);
            Console.WriteLine("=================================");

            Console.ReadLine();
        }
    }
}
