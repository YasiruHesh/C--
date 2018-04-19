using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Rect
    {
        //data
        private int height, width;
        //methods
        public void input()
        {
            Console.WriteLine("Enter a value for width:");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for height:");
            height = int.Parse(Console.ReadLine());
        }
        public int findArea()
        {
            int area = (width * height);
            return area;
        }
    }
}
