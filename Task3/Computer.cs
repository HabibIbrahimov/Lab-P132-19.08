using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    internal class Computer:Technology
    {
        public double Price;

        public Computer(string model,string brand,int stock) : base(model, brand, stock)
        {
            Model = model;
            Brand = brand;
            Stock=stock;

        }

        public int Stockk(int stock)
        {
            if (Stock-stock>=0)
            {
                Stock-=stock;
            }
            else
            {
                Console.WriteLine("stock tukenib");
            }
            return Stock;

        }
    }
}
