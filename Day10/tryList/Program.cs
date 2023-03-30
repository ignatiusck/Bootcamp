class Program
{
    public static void Main()
    {
        List<string> employee = new List<string>();
        employee.Add("Doni");
        employee.Add("John");
        employee.Add("Jane");
        employee.Add("Mike");

        foreach (var emp in employee)
        {
            Console.WriteLine(emp);
        }

        employee.Sort();
        Console.WriteLine();
        foreach (var emp in employee)
        {
            Console.WriteLine(emp);
        }

        string[] result = new string[5];
        employee.CopyTo(1, result, 1, 2);

        Console.WriteLine();
        foreach (var emp in result)
        {
            Console.WriteLine($"1 {emp}");
        }
    }
}