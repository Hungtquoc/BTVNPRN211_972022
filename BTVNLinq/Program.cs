using BTVNLinq;

internal class Program
{
    internal static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        Student s = new Student("he161699", "Tran Quoc Hung", DateTime.Parse("03/04/2002"), "se");
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
        LinqForStudent lfs = new LinqForStudent();
        students.Add(s);
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
        
        Console.WriteLine("List of option :");
        Console.WriteLine("1. List Student By ID ;");
        Console.WriteLine("2. List Student By Name ;");
        Console.WriteLine("3. List Student By Part of Name ;");
        Console.WriteLine("4. List Student By Major ;");
        Console.WriteLine("5. List Student By DoB ;");
        Console.WriteLine("6. List Student By Major and DoB ;");
        Console.WriteLine("7. Sort Student By ID and Name ;");
        Console.WriteLine("8. exit");
        while (true)
        {
            Console.Write("Enter your choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    lfs.ListStudentByID(students);
                    break;
                case 2:
                    lfs.listStudentByName(students);
                    break;
                case 3:
                    lfs.listStudentByPartName(students);
                    break;
                case 4:
                    lfs.listStudentMajor(students);
                    break;
                case 5:
                    lfs.listStudentDoB(students);
                    break;
                case 6:
                    lfs.listStudentMajorAndDoB(students);
                    break;
                case 7:
                    lfs.sortByIDAndName(students);
                    break;
                case 8:
                    return;
            }
        }       
    }
}