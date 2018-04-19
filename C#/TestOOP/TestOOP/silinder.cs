using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class silinder
    {
        float surfaceArea, height,radius,volume;
        public silinder()
        {
            radius = 10;
        }

        public void inputs()
        {
            Console.WriteLine("Enter surface radius:");
            radius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter height of the silinder:");
            height = Convert.ToSingle(Console.ReadLine());

        }
        public float calculateSurface()
        {
            float surfaceArea = Convert.ToSingle(3.14 * radius * radius);
            return surfaceArea;
        }
        public float calculateVolume()
        {
            float volume = surfaceArea*height;
            return volume;
        }
    }
}
