using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BT
{
    internal class Course
    {
        public string Code;
        public string StudySet;
        ArrayList studentList;

        public Course(string code, string studySet, ArrayList studentList)
        {
            Code = code;
            StudySet = studySet;
            this.studentList = studentList;
        }

        public Course()
        {
            studentList = new ArrayList();
        }

        public void addStudent(Student s)
        {
            if(!studentList.Contains(new Student(s.Code)) ) 
            {
                studentList.Add(s);
            }
        }
        public void inputCourse()
        {
            Console.WriteLine("Enter code course :");
            Code= Console.ReadLine();
            Console.WriteLine("Enter study set :");
            StudySet = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Course :" + Code+ " "+ StudySet);

            Console.WriteLine("Student list :");
            foreach(Student s in studentList)
            {
                s.Display();
                    
            }
        }
        public void writeText()
        {
            File.AppendAllText("D:\\Fall2022\\PRN211\\course.txt", Code+"\n");
            File.AppendAllText("D:\\Fall2022\\PRN211\\course.txt", StudySet+"\n");
            foreach(Student s in studentList)
            {
                File.AppendAllText("D:\\Fall2022\\PRN211\\course.txt", s.ToString()+"\n");
            }
        }
        public void readText()
        {
            string path = "D:\\Fall2022\\PRN211\\course.txt";
            string[] line= File.ReadAllLines(path);
            Console.WriteLine("-------------------------------------------");
            foreach (string line2 in line)
            {
                Console.WriteLine(line2);
            }
        }
        public void calculateFileSize()
        {
            string path = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(path);
            long FileLength = fileInfo.Length;
            Console.WriteLine("Độ lớn của file là: " + FileLength);
        }
        public static long GetFileSizeSumFromDirectory(string searchDirectory)
        {
            var files = Directory.EnumerateFiles(searchDirectory);
            var currentSize = (from file in files let fileInfo = new FileInfo(file) select fileInfo.Length).Sum();
            var directories = Directory.EnumerateDirectories(searchDirectory);
            var subDirSize = (from directory in directories select GetFileSizeSumFromDirectory(directory)).Sum();
            return currentSize + subDirSize;
        }
        
    }
}
