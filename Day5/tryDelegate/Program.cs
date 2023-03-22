using System;
class Program 
{
    static void Main() {
        calculate adding = add;
        int result = adding(10, 10);
        Console.WriteLine(result);
    }

    public delegate int calculate (int a, int b);

    public static calculate add = (a, b) => a + b;
}