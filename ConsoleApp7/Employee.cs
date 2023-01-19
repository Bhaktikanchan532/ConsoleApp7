using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Employee
    {
        private int empid;
        private string name;
        private double salary;
        //use methods toassign values too the variables
        public void Accept(int id, string nm, double sal)
        {
            empid = id;
            name = nm;
            salary = sal;
        }
        public string Display()
        {
            return $"Emp  ID {empid} name {name} percentage {salary}";
        }
    }
}
