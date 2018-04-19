using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestingfor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            char fkletter;
            for (fkletter = 'a'; fkletter <= 'z'; fkletter++)
            {

                for (num = 1; num <= 10; num++)
                {
                    Console.WriteLine("fuking number is {0}", num);
                }
                Console.WriteLine("the current letter is {0}", fkletter);
            }

            Console.ReadLine();
        }
    }
}
