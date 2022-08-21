using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    internal class Vurma:Calculator
    {
        public Vurma(double m, double n) : base(m, n)
        {

        }
        public double Vur()
        {
            return this.Num2 * this.Num1;
        }
    }
}
