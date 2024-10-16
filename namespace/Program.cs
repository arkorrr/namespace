//Task1
using Company.Department;

namespace Namespace1
{
    public class MyClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from Namespace1");
        }
    }
}

namespace Namespace2
{
    public class MyClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from Namespace2");
        }
    }
}
//Task2
namespace Company
{
    namespace Department
    {
        public class Employee
        {
            public void ShowDepartment()
            {
                Console.WriteLine("Employee belongs to Sales Department");
            }
        }
    }
}
//Task3
namespace MathOperations
{
    public class Operations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}

namespace StringOperations
{
    public class Operations
    {
        public string Concat(string a, string b)
        {
            return a + b;
        }
    }
}
//Task4
namespace Country1
{
    public class Capital
    {
        public int Population { get; set; } = 1000000;
    }
}

namespace Country2
{
    public class Capital
    {
        public int Population { get; set; } = 2000000;
    }
}

namespace Country3
{
    public class Capital
    {
        public int Population { get; set; } = 3000000;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Task1
        var obj1 = new Namespace1.MyClass();
        var obj2 = new Namespace2.MyClass();

        obj1.PrintMessage();
        obj2.PrintMessage();
        //Task2
        var employee = new Employee();
        employee.ShowDepartment();
        //Task3
        var mathOps = new MathOperations.Operations();
        var stringOps = new StringOperations.Operations();

        Console.WriteLine(mathOps.Add(10, 20));
        Console.WriteLine(stringOps.Concat("Hello", " World"));
        //Task4
        var capital1 = new Country1.Capital();
        var capital2 = new Country2.Capital();
        var capital3 = new Country3.Capital();

        Console.WriteLine($"Население столицы Country1: {capital1.Population}");
        Console.WriteLine($"Население столицы Country2: {capital2.Population}");
        Console.WriteLine($"Население столицы Country3: {capital3.Population}");
    }
}