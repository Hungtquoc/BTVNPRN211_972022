using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNLinq
{
    internal class LinqForStudent
    {
        public void ListStudentByID(List<Student> students)
        {
            Console.WriteLine("Enter Code of Student :");
            String id= Console.ReadLine();

            students.Where(x => x.Code.Equals(id)).ToList().Display("Student :");

        }
        public void listStudentByName(List<Student> students)
        {
            Console.WriteLine("Enter Name of Student :");
            String name = Console.ReadLine();

            students.Where(x => x.Name.Equals(name)).ToList().Display("Student :");

        }
        public void listStudentByPartName(List<Student> students)
        {
            Console.WriteLine("Enter Part Name of Student :");
            String name = Console.ReadLine();
            students.Where(x => x.Name.Contains(name)).ToList().Display("Student :");
        }
        public void listStudentMajor(List<Student> students)
        {
            Console.WriteLine("Enter Major of Student :");
            String major = Console.ReadLine();

            students.Where(x => x.Major.Equals(major)).ToList().Display("Student :");
        }
        public void listStudentDoB(List<Student> students)
        {
            Console.WriteLine("Enter DoB of Student :");
            DateTime Dob = DateTime.Parse(Console.ReadLine());

            students.Where(x => x.Dob.Equals(Dob)).ToList().Display("Student :");
        }
        public void listStudentMajorAndDoB(List<Student> students)
        {
            Console.WriteLine("Enter Major of Student :");
            String Major= Console.ReadLine();
            Console.WriteLine("Enter DoB of Student :");
            DateTime Dob = DateTime.Parse(Console.ReadLine());

            students.Where(x => x.Major.Equals(Major) && x.Dob.Equals(Dob)).ToList().Display("Student :");
        }
        public void sortByIDAndName(List<Student> students)
        {
            students.OrderBy(x => x.Code).ThenBy(x => x.Name).ToList().Display("Student");
        }
    }
}
