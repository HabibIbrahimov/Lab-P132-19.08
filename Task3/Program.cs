using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using task_2;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Technology Class 
            //Model
            // Brand

            // Stock
            // Computer Class Technology classindan miras alir.

            //Price

            //Satis Methodu var.Her defe method cagirilanda stockdan 1 cixilacaq.Eger stock 0 beraberdirse stockda computer yoxdur yazacaq.


            var comp = new Computer("HP", "P132", 7);
            Console.WriteLine(comp.Stockk(3));
        }
    }
}
