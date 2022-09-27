using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNLinq
{
    internal static class ListExtention
    {
        public static void Display(this List<Student> students, string mess)
        {
            Console.WriteLine(mess);
            foreach (Student s in students)
                Console.WriteLine(s);
        }
    }
}
