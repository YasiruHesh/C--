using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, yearstogo;
            Console.WriteLine("please enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 70)
                yearstogo = 70 - age;
            Console.WriteLine("Oh My God You Have another {0} years to go untill70", );
            else
            Console.WriteLine("uba dn naki..");

            Console.ReadLine();

        }
    
    }
}
