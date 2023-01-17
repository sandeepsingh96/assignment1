using System;

namespace Assignment1
{
    class Program
    {
        public static Student CreateStudent(int? id, StudentType type, String firstName, String lastName)
        {
            Student student = new Student();

            student.id = id ?? 0;
            student.type = type;
            student.firstName = firstName ?? "Unknown";
            student.lastName = lastName ?? "";



            return student;
        }
        static void Main(string[] args)
        {




            Console.WriteLine("Assignment One");

            CreateStudent(001, StudentType.FullTime, "Sandeep", "Singh");

            var student1 = CreateStudent(001, StudentType.FullTime, "Sandeep", "Singh");
            student1.OutputStudent();


            var student2 = CreateStudent(002, StudentType.PartTime, "Inderjeet", "Singh");


            student2.OutputStudent();







        }
    }
}

