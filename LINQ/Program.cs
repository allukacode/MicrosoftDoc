using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{					
    public class Program
    {
        delegate bool IsTeenAger(Student stud);
        public static void Main()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() { 
                    new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
                };

            // // LINQ Query Syntax to find out teenager students
            // var teenAgerStudent = from s in studentList
            //                       where s.Age > 12 && s.Age < 20
            //                       select s;
            // Console.WriteLine("Teen age Students:");

            // foreach (Student std in teenAgerStudent)
            // {
            //     Console.WriteLine(std.StudentName);
            // }
            // // LINQ Method Syntax to find out teenager students
            // var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();

        //     IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;
		
		//    Student stud = new Student() { Age = 25 };
		
		//     Console.WriteLine(isTeenAger(stud));

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                where s.Age > 12 && s.Age < 20
                                select s;
            Console.WriteLine("Teen age Students:");
                            
            foreach(Student std in teenAgerStudent)
            {			
                Console.WriteLine("r:" + std.StudentName);
            }

            
        }// Class Main
    }// Class Programm

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }


}