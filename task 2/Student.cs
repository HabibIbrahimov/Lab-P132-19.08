using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    internal class Student:Human 
    {
        public string Point;
        public string GroupNo;
        public string Password;
        public Student(string Name, string Surname,string Point):base(Name,Surname)
        {
            this.Point = Point;
        }
        public string GroupNumber() 
        {
            this.GroupNo = this.Name[0] + this.Point;
            return GroupNo;
        }
    }
}
