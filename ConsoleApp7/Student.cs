using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Student
    {
        private int rollno;
        private string name;
        private double percentage;
        //use methods toassign values too the variables
        public void Accept(int r, string nm, double per)
        {
            rollno = r;
            name = nm;
            percentage = per;
        }
        public string Display()
        {
            return $"Roll No {rollno} name {name} percentage {percentage}";
        }
    }
}
