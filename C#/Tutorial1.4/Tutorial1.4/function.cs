using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1._4
{
    class function
    {
        int mark;
        string Name,Grade;

        public void inputMarks()
        {
            Console.WriteLine("Enter Your Name:");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Mark for a subject:");
            mark = Convert.ToInt32(Console.ReadLine());
        }
        public string FindGrade()
        {
            if (mark >= 75)
                Grade = "Meritt";
            else if (mark > 65)
                Grade = "Distinction";
            else if (mark > 55)
                Grade = "Credit";
            else if (mark > 45)
                Grade = "Pass";
            else
                Grade = "you fail bitch";



            return Grade;
            
        }
    }
}
