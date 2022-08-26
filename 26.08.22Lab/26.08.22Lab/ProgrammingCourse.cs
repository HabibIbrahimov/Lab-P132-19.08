using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace _26._08._22Lab
{
    internal class ProgrammingCourse : ICourse
    {
        private int _studentLimit;
        private Student[] _students = new Student[0];


        public Student[] Students { get => _students; }
        public int StudentLimit
        {
            get => _studentLimit;
            set
            {
                if (value >= _students.Length)
                    _studentLimit = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null) return;
            if(_students.Length < _studentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
         
        }

        public Student[] SearchStudentByGroupNo(string groupNo)
        {
            Student[] Students = new Student[0];

            for (int i = 0; i < _students.Length; i++)
            {
                if(_students[i].GroupNo == groupNo)
                {
                    Array.Resize(ref Students, Students.Length + 1);
                    Students[Students.Length - 1] = _students[i];
                }
            }
            return Students;
        }

        public void SearchForNameOrGroupNo(string txt)
        {
            txt = txt.ToLower();
            for (int i = 0; i < _students.Length; i++)
            {
                string fullName = _students[i].Name + " " + _students[i].Surname;

                if (fullName.ToLower().Contains(txt) || _students[i].GroupNo.ToLower().Contains(txt))
                    _students[i].ShowInfo();
               
            }
        }
    }
}
