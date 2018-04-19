using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doloop1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            message = "Hi";
            do
            {
                message = message + "i";
                Console.WriteLine(message);
            } while (message.Length <= 20);
            Console.ReadLine();
        }
    }
}
