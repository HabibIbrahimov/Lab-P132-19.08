using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] students = new Student[5];

            students[0] = new Student("Abbas", "Eliyev", "95");
            Console.WriteLine(students[0].GroupNumber());


        }
    }
}
