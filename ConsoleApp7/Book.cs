using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Book
    {
        private string authorname;
        private string bookname;
        private double price;
        //use methods toassign values too the variables
        public void Accept(string a, string bn, double p)
        {
            authorname = a;
            bookname = bn;
            price = p;
        }
        public string Display()
        {
            return $"Author name {authorname} Book name {bookname} price {price}";
        }
    }
}
