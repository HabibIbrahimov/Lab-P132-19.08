using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    internal class Cixma:Calculator
    {
        public Cixma(double m, double n) : base(m, n)
        {

        }
        public double Cix()
        {
            return this.Num1 - this.Num2;
        }
    }
}
