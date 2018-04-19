using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1._3
{
    class Circle
    {
        float radius;
        int colourType;
        /*public Circle(float r,int co)
        {
            radius = r;
            colourType = co;
        }*/

        public void SetCircleInfo()
        {
            Console.WriteLine("Enter radius:");
            radius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Colour to be appear:");
            colourType = Convert.ToInt32(Console.ReadLine());
        }
        public float calculateArea()
        {
            float area = Convert.ToSingle (3.14 * radius * radius);
            return area;
        }


    }
}
