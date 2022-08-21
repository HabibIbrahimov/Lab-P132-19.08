using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    internal class Toplama:Calculator
    {
        public Toplama(double m, double n) : base(m, n)
        {

        }
        public double Topla()
        {
            return this.Num2 + this.Num1;
        }
    }
}
