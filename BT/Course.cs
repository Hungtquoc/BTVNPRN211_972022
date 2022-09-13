using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    internal class Course
    {
        public string Code;
        public string StudySet;
        ArrayList studentList;

        public Course(string code, string studySet, ArrayList studentList)
        {
            Code = code;
            StudySet = studySet;
            this.studentList = studentList;
        }

        public Course()
        {
            studentList = new ArrayList();
        }

        public void addStudent(Student s)
        {
            if(!studentList.Contains(new Student(s.Code)) ) 
            {
                studentList.Add(s);
            }
        }
        public void inputCourse()
        {
            Console.WriteLine("Enter code course :");
            Code= Console.ReadLine();
            Console.WriteLine("Enter study set :");
            StudySet = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Course :" + Code+ " "+ StudySet);

            Console.WriteLine("Student list :");
            foreach(Student s in studentList)
            {
                s.Display();
            }
        }
    }
}
