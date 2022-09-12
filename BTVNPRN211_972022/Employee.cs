using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNPRN211_972022
{
    internal class Employee
    {
        int code;
        string name;
        double basesalary;
        public int Code { get { return code; } set { code = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double BaseSalary { get { return basesalary; } set { basesalary = value; } }

        public Employee()
        {
        }

        public Employee(int code, string name, double basesalary)
        {
            this.code = code;
            this.name = name;
            this.basesalary = basesalary;
        }
        public override string ToString()
        {
            return "Code " + Code + " Name " + Name + " Basesalary" + BaseSalary;
        }
        public void Input()
        {
            Console.WriteLine("Enter Code:");
            Code = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();

            Console.WriteLine("Enter BaseSalary :");
            BaseSalary = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Code: " + Code + " Name: " + Name + " Basesalary: " + BaseSalary);
        }
    }
}
