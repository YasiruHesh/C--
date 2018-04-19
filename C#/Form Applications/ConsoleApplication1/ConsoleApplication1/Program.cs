using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            c.input();

            Console.WriteLine("Substraction is  :" + c.calculateSub());
            Console.WriteLine("addition is      :" + c.calculateAdd());
            Console.WriteLine("Multiplication is:" + c.calculateMult());
            Console.WriteLine("Divition is      :" + c.calculateDiv());
            Console.ReadLine();

        }
    }
}
