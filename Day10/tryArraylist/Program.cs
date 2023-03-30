using System.Collections;
class Program
{
    public static void Main()
    {
        ArrayList emp = new();
        emp.Add("dono");
        emp.Add("adi");
        emp.Add("budi");
        emp.Add("ani");

        foreach (var item in emp)
        {
            Console.WriteLine(item);
        }

        ArrayList emp2 = new() { "dono", "adi", "budi", "ani" };

        Console.WriteLine();
        foreach (var item in emp2)
        {
            Console.WriteLine(item);
        }

        emp.Sort();
        Console.WriteLine();
        foreach (var item in emp)
        {
            Console.WriteLine(item);
        }

        IList emp3 = (IList)emp.Clone();
        Console.WriteLine();
        foreach (var item in emp3)
        {
            Console.WriteLine(item);
        }
    }
}