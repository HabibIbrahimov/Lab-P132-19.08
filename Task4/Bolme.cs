using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    internal class Bolme:Calculator
    {
        public Bolme(double m, double n ):base(m,n)
        {

        }

        public double Bol()
        {
            if(this.Num2 != 0)
           return this.Num1 / this.Num2;
            return -1;

            
        }
    }
}
