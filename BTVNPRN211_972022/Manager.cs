using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNPRN211_972022
{
    internal class Manager: Employee
    {
        double bonus;
        
        public double Bonus { get { return bonus; } set { bonus = value; } }

        public Manager()
        {
        }

        public Manager(int code, string name, double basesalary, double bonus) : base(code, name, basesalary)
        {
            this.bonus = bonus;
        }
        public double GetSalary()
        {
            return (1+bonus)*BaseSalary;
        }
        public override string ToString()
        {
            return Code + " " + Name + " " +GetSalary() ;
        }
        public void input()
        {
            Console.WriteLine("Enter Code:");
            Code = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();

            Console.WriteLine("Enter BaseSalary :");
            BaseSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Bonus:");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine(Code + " " + Name + " " + GetSalary());
        }
        
    }
}
