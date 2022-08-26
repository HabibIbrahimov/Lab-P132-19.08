using System;

namespace _26._08._22Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //  student.Name = "tahir";
            //  student.Surname = "tahirli";
            //  student.GroupNo = "PPP1";

            //  student.GetInfo();

            //  Student student2 = new Student();
            //  student2.Name = "Samir";
            //  student2.GroupNo = "D155";


            //  ProgrammingCourse course = new ProgrammingCourse();
            //  course.StudentLimit = 2;
            //  course.AddStudent(student);
            //  course.AddStudent(student2);

            //var array =  course.SearchStudentByGroupNo("D155");

            //  for (int i = 0; i < array.Length; i++)
            //  {

            //      array[i].GetInfo();
            //  }

            ProgrammingCourse course = new ProgrammingCourse();
            course.StudentLimit = 3;

            string choice;

            do
            {
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Telebeleri goster");
                Console.WriteLine("3.Telebeleri group nomresine gore gosder");
                Console.WriteLine("4. axtaris edin");
                Console.WriteLine("0.cix");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // telebe elave et
                        Student student = new Student();
                        Console.WriteLine(" ad:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Soyad: ");
                        string surname = Console.ReadLine();

                        string groupNo;
                        bool checkGroup = true;
                        do
                        {
                            if(!checkGroup)
                            {
                                Console.WriteLine("group nomresi boyuk herfle baslamali ve uc reqemli olmalidir");
                            }
                            Console.WriteLine("GroupNO : ");
                             groupNo = Console.ReadLine();
                            checkGroup = false;

                        } while (!student.CheckGroupNo(groupNo));


                        bool checkPoint = true;
                        int point;
                        do
                        {
                            if (!checkPoint)
                            {
                                Console.WriteLine("qiymet 0-100 araliginda olmalidir");
                            }
                            Console.WriteLine("point : ");
                             point = Convert.ToInt32(Console.ReadLine());

                            checkPoint = false;


                        } while (point < 0 ||  point >100);
                       
                        student.Name = name;
                        student.Surname = surname;
                        student.Point = point;
                        student.GroupNo = groupNo;


                        course.AddStudent(student);
                        break;
                    case "2":
                        //telebe gosder
                        var telebeler = course.Students;
                        for (int i = 0; i < telebeler.Length; i++)
                        {
                            telebeler[i].ShowInfo();
                        }
                        break;
                    case "3":
                        //group no daxil 
                        // telebelri gosder
                        Console.WriteLine("Group no daxil edin");
                        string wanted = Console.ReadLine();

                        var filtered = course.SearchStudentByGroupNo(wanted);

                        for (int i = 0; i < filtered.Length; i++)
                        {
                            filtered[i].ShowInfo();
                        }


                        break;

                    case "4":
                        Console.WriteLine("Axtaris edin");
                        string wantedstr = Console.ReadLine();

                        course.SearchForNameOrGroupNo(wantedstr);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Sehv secim etdiniz, yeniden daxil edin");
                        break;
                }



            } while (choice!="0");






        }
    }
}
