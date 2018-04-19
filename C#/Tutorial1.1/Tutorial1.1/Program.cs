using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name1, StdNumber ;
            int BirthYear, age, CurrentYear;
            Console.WriteLine("Enter Student ID:");
            StdNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Birth Year:");
            BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Current Year:");
            CurrentYear = Convert.ToInt32(Console.ReadLine());
            age = CurrentYear - BirthYear;

            Console.WriteLine("Hi {0} Yasiru", StdNumber);
            Console.WriteLine("Your age is {0}", age);

            
            Console.ReadLine();
        }
    }
}
