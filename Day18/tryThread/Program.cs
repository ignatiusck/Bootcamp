using System.Threading;
class Program
{
    public static void Main(string[] args)
    {
        Thread thread = new(() => Console.WriteLine("from thread"));
        thread.Start();
    }
}