using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            silinder s = new silinder();
           // s.inputs();

            Console.WriteLine("area of the surface is:{0}", s.calculateSurface());

            Console.WriteLine("Volume of the silinder is:{0}", s.calculateVolume());
            
            Console.ReadLine();
        }
    }
}
