using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class calculator
    {
        double num1, num2,answer;
        int nombare;

        public void input()
        {
            Console.WriteLine("Enter Fucking Number 1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Fucking Number 2:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter wht u want to do:");
            nombare = Convert.ToInt32(Console.ReadLine());

        }
        public double calculateSub()
        {
            answer = num1 - num2;
            return answer;
        }
        public double calculateAdd()
        {
            answer = num1 + num2;
            return answer;
        }
        public double calculateMult()
        {
            answer = num1 * num2;
            return answer;
        }
        public double calculateDiv()
        {
            answer = num1 / num2;
            return answer;
        }
     
    }
}
