
using System;
namespace Assignment1
{
    struct Student
    {
        public int id;
        public StudentType type;
        public String firstName;
        public String lastName;




        public void OutputStudent()
        {
            int takenId = this.id;
            StudentType takenType = this.type;
            String takenFirstname = this.firstName;
            String takenLastname = this.lastName;

            Console.WriteLine("Student: " + takenId + ' ' + takenFirstname + ' ' + takenLastname + " (" + takenType + ')');

        }

    }
}



