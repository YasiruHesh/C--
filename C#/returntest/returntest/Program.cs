using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returntest
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            Console.WriteLine("please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your Name:");
            name = Console.ReadLine();

            Console.WriteLine("Hi {0}, your age is {1}.. oya dn naki :)", name, age);
            Console.ReadLine();

            decad(age, name);
        }

       

    }
}
