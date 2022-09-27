using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BTVNLinq
{
    internal class Student 
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
    
    }
        
}
