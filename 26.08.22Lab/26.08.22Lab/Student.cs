using System;
using System.Collections.Generic;
using System.Text;

namespace _26._08._22Lab
{
    internal class Student
    {
        public string Name;
        public string Surname;
        private string _groupNo;
        private int _point;

        public int Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value>=0 && value<=100)
                {
                    _point = value;
                }
            }
        }

        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Info: {Name} {Surname} {GroupNo}");
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (String.IsNullOrEmpty(groupNo) || !char.IsLetter(groupNo[0]) || !char.IsUpper(groupNo[0]) || groupNo.Length != 4)
                return false;

            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!Char.IsDigit(groupNo[i]))
                return false;
            }
            return true;
        }
    }
}
