class Program
{
    //try array
    public static void Main()
    {
        Employee emp1 = new("budi");
        Employee emp2 = new("ani");
        Employee emp3 = new("dino");
        Employee emp4 = new("bobi");
        Employee[] employees = { emp1, emp2, emp3, emp4 };

        Employee[] depts = new Employee[4];
        depts[0] = emp1;
        depts[1] = emp2;
        depts[2] = emp3;
        depts[3] = emp4;

        Employee[] deptsNew = new Employee[4] { emp1, emp2, emp3, emp4 };

        for (int i = 0; i < deptsNew.Length; i++)
        {
            Console.WriteLine(deptsNew[i].name);
        }

        Console.WriteLine();
        foreach (var dept in depts)
        {
            Console.WriteLine(dept.name);
        }

        Array.Sort(depts, (a, b) => a.name.CompareTo(b.name));

        Console.WriteLine();
        foreach (var dept in depts)
        {
            Console.WriteLine(dept.name);
        }
    }

    class Employee
    {
        public string name { get; set; }
        public int age;
        public Employee(string name)
        {
            this.name = name;
        }
    }
}