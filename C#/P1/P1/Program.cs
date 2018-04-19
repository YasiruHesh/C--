using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            x = 123.456789f;
            Console.WriteLine("The results interest earned was {0}", x);
            Console.WriteLine("The results interest (Formated) earned was{0}", x.ToString("N2"));
            Console.WriteLine(string.Format("The results interest(formated as well) earned was {0:$.00}", x));
            Console.ReadLine();
        }
    }
}
