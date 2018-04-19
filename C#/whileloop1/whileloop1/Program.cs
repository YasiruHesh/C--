using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = 10;
            while(age<70)
            {
                age = age + 10;
                Console.WriteLine("Your age is {0}",age);
            }
            Console.ReadLine();
        }
    }
}
