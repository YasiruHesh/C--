using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;

            for (x = 0; x <= 40; x++)
                Console.WriteLine(x);
            Console.ReadLine();*/

            /*char letter;
            for (letter = 'a'; letter <= 'z'; letter++)
                Console.WriteLine(letter);
            Console.ReadLine();*/

            /* char akura;
             for (akura = 'z'; akura >= 'a'; akura--)
                 Console.Write(akura);
             Console.ReadLine();*/

            char letter;
            for(letter='z';letter>='a';letter--)
            {
                Console.WriteLine(letter);
                Console.Beep();
                Console.WriteLine("and the next letter is{0}");

                Console.ReadLine();
            }
        }
    }
}
