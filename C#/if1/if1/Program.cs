using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if1
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance;
            Console.WriteLine("please enter your bank balance:");
            balance = Convert.ToDouble(Console.ReadLine());

            if (balance > 0) ;
            Console.WriteLine("Your bank balance ia {0}", balance.ToString());

            Console.ReadLine();
        }
    }
}
