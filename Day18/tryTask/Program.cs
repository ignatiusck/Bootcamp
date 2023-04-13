using System.Threading.Tasks;
class Program
{
    public static async Task Main(string[] args)
    {
        // Task<int> task3 = new(Print);
        // await task3.Start();
        // int result = 2;

        // Console.WriteLine(result);
        Task<int> result1 = Task.Run(() => 10);
        Console.WriteLine(result1.Result);

        int task1 = await Task.Run(Print);
        int task2 = await Task.Run(Print);
        Console.WriteLine($"main" + task1 + task2);
    }

    static async Task<int> Print()
    {
        Console.WriteLine("Task done");
        Task.Delay(1000);
        return 10;
    }

}
