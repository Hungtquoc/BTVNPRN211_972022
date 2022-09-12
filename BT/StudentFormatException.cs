using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BT
{
    internal class StudentFormatException 
    {
        public String CheckInputCode()
        {
            while (true)
            {
                Console.WriteLine("Enter Code: ");
                String Code = Console.ReadLine();
                Regex regex = new Regex("^[a-zA-Z]{2}[0-9]{6}");
                if (!regex.IsMatch(Code))
                {
                    Console.WriteLine("invalid code pls input agian");
                }
                else
                {
                    return Code;       
                }
            }
        }
        public String CheckInputName()
        {
            while (true)
            {
                Console.WriteLine("Enter Name :");
                String Name = Console.ReadLine();
                if (String.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("U String is empty pls input again:");
                }
                else
                {
                    return Name;
                }
            }
        }
        public DateTime CheckInputDoB()
        {
            Console.WriteLine("Enter Date of birth :");
            DateTime Dob = Convert.ToDateTime(Console.ReadLine());
            DateTime DateNow = DateTime.Now;
            int age = DateNow.Year - Dob.Year;
            while (true)
            {
                if ((age <= 17) || (age >= 60))
                {
                    Console.WriteLine("invalid Dob Pls Input Again. Your age now is "+age+ " <17 or >60");
                    Console.WriteLine("Enter Date of birth :");
                    Dob = Convert.ToDateTime(Console.ReadLine());
                    age = DateNow.Year - Dob.Year;
                }
                else
                {
                    return Dob;
                }
            }
            
        }
        public string CheckInputMajor()
        {
            Console.WriteLine("Enter You Major only SE, SB, IA, AI, IOT, GD :");
            String Major = Console.ReadLine().ToUpper();
            while (true)
            {
                if (String.IsNullOrEmpty(Major))
                {
                    Console.WriteLine("Enter Something: ");
                    Major= Console.ReadLine().ToUpper();
                }
                else if (Major.Equals("SE")|| Major.Equals("SB") || Major.Equals("IA") || Major.Equals("AI") || Major.Equals("IOT") || Major.Equals("GD") )
                {
                    return Major;
                    
                }
                else
                {
                    Console.WriteLine("Invalid major, Input major again  You Major only SE, SB, IA, AI, IOT, GD : ");
                    Major = Console.ReadLine().ToUpper();
                }
            }
        }
    }
}


