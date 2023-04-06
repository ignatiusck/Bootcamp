class Program
{
    public static void Main()
    {
        int a = 10;
        int b = 20;

        int result = Operator.Add(() => a + b);
        Console.WriteLine($"{result}");

        Calculator adding = (a, b) => a + b;
        result = adding(4, 3);
        Console.WriteLine($"{result}");

        result = Operator.Add(adding(a, b));

        Func<int, string, int> results = (tot, name) => 3 + 4 + tot + 5;

        results(10, "hello");
    }

    public delegate int Calculator(int a, int b);

    static class Operator
    {
        public static int Add(Func<int> cal)
        {
            return cal() + 10;
        }

        internal static int Add(int v)
        {
            throw new NotImplementedException();
        }
    }
}