using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace _19._08._22
{
    internal class Product
    {
        public Product(int no, string name, double price)
        {
            No = no;
            Name = name;
            Price = price;
        }

        public int No;
        public string Name;
        public double Price;
        public int Count;

    }
}
