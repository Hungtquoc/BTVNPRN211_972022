using BTVNPRN211_972022;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.Input();
        e1.Display();
        Manager m1 = new Manager();
        m1.input();
        m1.display();
    }
}