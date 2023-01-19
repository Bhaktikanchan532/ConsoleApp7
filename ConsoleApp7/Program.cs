using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.Accept(101, "Rohan", 78.77);
            string result = stud.Display();
            Console.WriteLine(result);

            //object for emp
            Employee emp = new Employee();
            emp.Accept(10, "POOJA", 3.5);
            string res = emp.Display();
            Console.WriteLine(res);

            Book bk = new Book();
            bk.Accept("xyz", "Yugandhar", 1000);
            string rst = bk.Display();
            Console.WriteLine(rst);
        }
    }
}
