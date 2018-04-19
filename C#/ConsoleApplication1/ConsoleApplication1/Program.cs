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
            string valueAsString;
            int valueAsNumber;
            valueAsString = "255";
            valueAsNumber = Convert.ToInt32(valueAsString);
            Console.WriteLine("{0}",valueAsNumber);
            Console.ReadLine();        }
    }
}
