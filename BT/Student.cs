using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BT
{
    internal class Student : IComparable<Student>
    {
        public string Code;
        public string Name;
        public DateTime Dob;
        public string Major;

        public Student()
        {
        }

        public Student(string code, string name, DateTime dob, string major)
        {
            Code = code;
            Name = name;
            this.Dob = dob;
            Major = major;
        }

        public Student(string code)
        {
            Code = code;
        }

        public override string ToString()
        {
            return Code + "| " + Name + "| " + Dob + "| " + Major;
        }
        public void Display()
        {
            Console.WriteLine(ToString());
        }
        public void Input()
        {
            StudentFormatException sfe = new StudentFormatException();
            sfe.CheckInputCode();
            sfe.CheckInputName();
            sfe.CheckInputDoB();
            sfe.CheckInputMajor();
        }
        
        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   Code == student.Code;
        }

        public int CompareTo(Student? other)
        {
            return this.Code.CompareTo(other.Code);
        }
        public static int CompareToByDoB(Student s1, Student s2)
        {
            return s1.Dob.CompareTo(s2.Dob);
        }
        public static int CompareToByMajor(Student s1, Student s2)
        {
            return s1.Major.CompareTo(s2.Major);
        }
    }
    class ComparebyName : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    
}
