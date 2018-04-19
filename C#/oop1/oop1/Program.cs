using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect r = new Rect();
            r.input();

            Console.WriteLine("the area is" +r,findArea());
            Console.ReadLine();
        }
    }
}
