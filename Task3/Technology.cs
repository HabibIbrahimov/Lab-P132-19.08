using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    internal class Technology
    {
        public string Model;
        public string Brand;
        public int Stock;

        public Technology(string model, string brand, int stock)
        {
            Model = model;
            Brand = brand;
            Stock = stock;
        }
    }
}
