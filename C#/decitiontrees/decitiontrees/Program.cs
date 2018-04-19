using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decitiontrees
{
    class Program
    {
        static void Main(string[] args) 
        {
            double cost, delfee;
            int distance;

            Console.WriteLine("Please enter the cost of the goods:");
            cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the distance:");
            distance = Convert.ToInt32(Console.ReadLine());

            if (distance <= 5)
                delfee = 0;
            else if (cost >= 10)
                delfee = 1.5;
            else
                delfee = 3.00;

            Console.WriteLine("The delivery cost is {0}", delfee.ToString("c"));
            Console.ReadLine();
                
        }
    }
}
