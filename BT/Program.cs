using BT;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s = new Student("he161699", "Hung", DateTime.Parse("03/04/2002"), "se");
        Student s1 = new Student("he163679", "Manh", DateTime.Parse("01/03/2003"), "sb");
        Student s2 = new Student("he171679", "Khanh", DateTime.Parse("11/03/2004"), "ai");
        Student s3 = new Student("he171879", "Quoc", DateTime.Parse("11/07/2003"), "iot");
        Student s4 = new Student("he160679", "Tran", DateTime.Parse("03/06/2002"), "gd");
        Student s5 = new Student("he171679", "Joyce", DateTime.Parse("12/24/2003"), "ia");
        Student s6 = new Student("he151679", "Kien", DateTime.Parse("11/02/2003"), "iot");
        Student s7 = new Student("he171639", "Hong", DateTime.Parse("06/05/2003"), "ai");
        Student s8 = new Student("he145679", "Nhung", DateTime.Parse("08/04/2004"), "sb");
        Student s9 = new Student("he181679", "Lan", DateTime.Parse("11/09/2003"), "gd");
        Student s10 = new Student("he171679", "Hien", DateTime.Parse("03/06/2002"), "ia");
        
        List<Student> students = new List<Student>();
        students.Add(s1);
        students.Add(s2);
        students.Add(s3);
        students.Add(s4);
        students.Add(s5);
        students.Add(s6);
        students.Add(s7);
        students.Add(s8);
        students.Add(s9);
        students.Add(s10);
        students.Add(s);
        students.Sort();
        

        foreach(Student sd in students)
        {
            Console.WriteLine(sd);
        }
        Console.WriteLine("------------------------------------");
        students.Sort(new ComparebyName());
        foreach(Student st in students)
        {
            Console.WriteLine(st);
        }
        Console.WriteLine("------------------------------------");
        students.Sort((x, y) => x.Dob.CompareTo(y.Dob));
        foreach (Student st in students)
        {
            Console.WriteLine(st);
        }
        Console.WriteLine("------------------------------------");
        students.Sort((x, y) => x.Major.CompareTo(y.Major));
        foreach (Student st in students)
        {
            Console.WriteLine(st);
        }
        //s.Input();
        //s.Display();
        Course course = new Course();
        /*course.inputCourse();
        course.addStudent(s);
        course.addStudent(s1);
        course.addStudent(s2);

        //course.display();
        course.writeText();
        course.readText();
        */
        //course.calculateFileSize();
        //string path = Console.ReadLine();
        //Console.WriteLine(Course.GetFileSizeSumFromDirectory(path));
        /*while (true)
	    {
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    s.Input();
                    course.addStudent(s);
                    course.inputCourse();
                    break;
                case 2:
                    course.display();
                    break;
                case 3: 
                    return;
            }
          */  
            
	    }

    }
    
