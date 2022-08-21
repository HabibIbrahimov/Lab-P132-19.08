using System;
using System.Collections.Generic;
using System.Text;

namespace _19._08._22
{
    internal class Book : Product
    {
        public Book(int no, string name, double price) : base(no, name, price)
        {
            
        }
        public string Genre;
    }
}
