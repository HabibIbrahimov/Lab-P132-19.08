using System;
using task_2;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Toplama, cixma, bolme, vurma, classlari yaradin.
            //  Calculator classi yaradin
            //  - num1
            //  - num2

            //Bunlar hamisi calculator classindan miras alacaq.
            //Toplama cixma bolme vurma classlarininda içinde hesablama methodlari olacaq.

            Vurma vurma = new Vurma(5, 6);
            Console.WriteLine(vurma.Vur());
        }
    }
}
