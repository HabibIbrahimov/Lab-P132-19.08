using System;
using System.Collections.Generic;
using System.Text;

namespace _26._08._22Lab
{
    internal interface ICourse
    {
        public Student[] Students { get; }
        public int StudentLimit { get; set; }

        void AddStudent(Student student);
        Student[] SearchStudentByGroupNo(string groupNo);
    }
}
