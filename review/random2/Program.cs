class Program
{
    public static void Main()
    {
        calculator operasion = Operators.sum;
        operasion += Operators.sub;

        int result = operasion.Invoke(10, 5);
        Console.WriteLine(result);

        Operator.completedCal += Operators.sub;
        Operator.completedCal += Operators.sum;

        Operator.start();

        Console.WriteLine($"{Operator.result}");


    }

    public delegate int calculator(int a, int b);

    static public class Operator
    {
        public static event calculator completedCal;
        public static int result;

        public static void start()
        {
            Console.WriteLine($"rendering done.");

            Thread.Sleep(1000);

            result = completedCal.Invoke(10, 9);
        }
    }

    static class Operators
    {
        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }
    }
}