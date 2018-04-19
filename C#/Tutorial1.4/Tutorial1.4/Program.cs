using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            function f = new function();
            f.inputMarks();

            Console.WriteLine("Your Grade is:{0}",f.FindGrade());
            Console.ReadLine();

        }
    }
}
