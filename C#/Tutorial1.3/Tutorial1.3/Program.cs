using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.SetCircleInfo();

            Console.WriteLine("The area of the circle is:{0}",c.calculateArea());
            Console.ReadLine();
        }
    }
}
