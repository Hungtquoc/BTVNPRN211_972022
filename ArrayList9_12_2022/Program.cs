using BTVNPRN211_972022;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        for(int i = 0; i < employees.Count; i++)
        {
            Employee employee = new Employee();
            employees.Add(employee);
        }
        employees.Count();
    }
    public void DemoUsingArrayList()
    {
        ArrayList list1 = new ArrayList();
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(4);
        list1.Add(5);
        ArrayList list2 = new ArrayList();
        
        ArrayList list3 = new ArrayList();
        list3.Add(new Employee(1,"Hung",30000));
    }
}