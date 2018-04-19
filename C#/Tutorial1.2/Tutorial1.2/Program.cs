using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ItemNumber, description;
            int quantity, price, totalPrice;
            Console.WriteLine("Enter Item Number:");
            ItemNumber = Console.ReadLine();
            Console.WriteLine("Enter Item Description:");
            description = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Unit Price:");
            price = Convert.ToInt32(Console.ReadLine());
            totalPrice = quantity * price;

            Console.WriteLine("item number:{0} and the description is:{1}", ItemNumber,description);
            Console.WriteLine("Total cost is:{0}", totalPrice);

            Console.ReadLine();


        }
    }
}
