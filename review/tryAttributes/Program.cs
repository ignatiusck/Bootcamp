using System.Runtime.CompilerServices;
using System;

class Program
{
    static void Main()
    {
        Foo();
        SortedList<int, object> obj = new() { { 1, "name" }, { 2, "first" }, { 3, "thrith" } };

        foreach (var item in obj.Keys)
        {
            Console.WriteLine($"{item}");
        }

        obj.Remove(2);
        foreach (var item in obj.Keys)
        {
            Console.WriteLine($"{item}");
        }
    }
    static void Foo(
    [CallerMemberName] string memberName = null,
    [CallerFilePath] string filePath = null,
    [CallerLineNumber] int lineNumber = 0)
    {
        Console.WriteLine(memberName);
        Console.WriteLine(filePath);
        Console.WriteLine(lineNumber);
    }

}