class Program
{
    public static void Main()
    {
    }

    public delegate int myDelegate(int a, int b);

    public class Calculator
    {
        public event myDelegate completed;
        public int add(int a, int b)
        {
            return a + b;
        }
    }

    public class notify
    {
        public void complete(object sender, EventArgs es)
        {
            Console.WriteLine("succed.");

        }
    }
}