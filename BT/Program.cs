using BT;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s = new Student("he161699", "Hung", DateTime.Parse("03/04/2002"), "se");
        Student s1 = new Student("he161699", "Hung@", DateTime.Parse("03/04/2002"), "se");
        Student s2 = new Student("he171679", "HungHK", DateTime.Parse("03/04/2002"), "se");

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
        string path = Console.ReadLine();
        Console.WriteLine(Course.GetFileSizeSumFromDirectory(path));
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
    
