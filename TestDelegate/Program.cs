using System.IO;
delegate int numberchange(int n);
namespace testDelegate
{
    class testDelegate
    {
        static int num = 10;
        public static int addNum(int n)
        {
            num += n;
            return num;
        }
        public static int multNum(int n)
        {
            num *= n;
            return num;
        }
        public static int get()
        {
            return num;
        }
        static void Main(string[] args)
        {
            numberchange n = new numberchange(addNum);
            numberchange n1= new numberchange(multNum);
            n(10);
            Console.WriteLine("giá trị của số: {0}", get());
            n1(5);
            Console.WriteLine("giá trị của số: {0}", get());
        }
    }
}