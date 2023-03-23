using System;
class Program
{
    static void Main()
    {
        Calculator cal = new Calculator();

        calculate adding = cal.add;
        int result = adding(10, 4);

        calculate multiplying = cal.multiply;
        int result2 = multiplying(29, 3);

        Console.WriteLine($"{result}, {result2}");
    }

    public delegate int calculate(int a, int b);

    class Calculator
    {
        public calculate add = (a, b) => a + b;

        public calculate multiply = (a, b) => a * b;
    }

}

